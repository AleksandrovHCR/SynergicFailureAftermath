﻿using SynergicFailureAftermath.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Runtime.InteropServices;

namespace SynergicFailureAftermath.Classes
{
    public class Graph
    {
        private List<Link> All_Links;//Все узлы
        

        public Graph() {  All_Links = new List<Link> { }; }
        public int GetNLinks() => All_Links.Count;
        public int AddLink(Link link) { All_Links.Add(link); return 0;}
        public Link GetLink(int Index)=> All_Links[Index];
        public void RemoveLink(int Index) {  All_Links.RemoveAt(Index); }

        ~Graph()
        {
            All_Links.Clear();
        }



        public bool GraphCheck()
        {
            foreach(Link link in All_Links)
            {
                if(link.GetLinkInstance()==2)
                    return false;
            }
            return true;
        }
        public void Energize()//Запуск графа
        {
            
                //foreach (Link link in All_Links)
                //{
                //    if (link.GetLinkInstance() == 1 )
                //        link.ProvideEnergy();
                //}
                
                //foreach (Link link in All_Links)
                //{
                //    if (link.GetLinkInstance() == 3)
                //        link.DisableBranch();
                //}
            for(int i = 0; i < All_Links.Count; i++)
            {
                if (All_Links[i].GetLinkInstance()==1 || All_Links[i].CheckConnectedLinks())
                    All_Links[i].ProvideEnergy();
            }
            foreach (Link link in All_Links)
                {
                    if (link.GetLinkInstance() == 3 || link.CheckBrokenLinks())
                        link.DisableBranch();
                }    
        }
        public List<Link> GetBrokenLinks()
        {
            List < Link > BLinks = new List<Link>() { };
            foreach (Link link in All_Links)
            {
                if(link.GetLinkInstance()==3)
                    BLinks.Add(link);
            }
            return BLinks;
        }
        public int GetCriticalLinksCount()
        {
            int i = 0;
            foreach (Link link in All_Links)
            {
                if (link.GetLinkType() == 4)
                    i++;
            }
            return i;
        }


        public List<int> GetCriticalIndexs()
        {
            List<int> temp = new List<int>() { };
            foreach (Link link in All_Links)
            {
                if(link.GetLinkType()==4)
                    temp.Add(link.getIndex());
            }
            return temp;
        }

        public void RecordFileToWindows(StreamWriter Writer1)
        {
            foreach (Link link in All_Links)
            { 
                string ReadBuffer=null;
                ReadBuffer += link.getIndex().ToString()+" ";
                ReadBuffer += link.GetLinkType().ToString()+" ";
                for (int i = 0;i< link.GetLinks();i++) {
                    ReadBuffer+=link.GetConnectedLink(i).getIndex().ToString()+" ";
                }
                Writer1.WriteLine(ReadBuffer);
            }
            Writer1.Close();
        }
        private void DataGridUpd(MainWindow MW)
        {

            MW.Graph_datagrid.ColumnCount = this.GetNLinks() + 1;
            MW.Graph_datagrid.Columns[this.GetNLinks()].Name = $"{this.GetNLinks()}";
            MW.Graph_datagrid.Rows.Add();
            MW.Graph_datagrid[0, this.GetNLinks() - 1].Value = this.GetNLinks();
            MW.Graph_datagrid[this.GetNLinks(), this.GetNLinks() - 1].Value = "-";
        }
        private void DataGridUpd2(MainWindow MW)
        {
            for (int i = 1; i < MW.Graph_datagrid.Columns.Count; i++)
            {
                Link G = this.GetLink(i - 1);
                for (int j = 0; j < MW.Graph_datagrid.Columns.Count; j++)
                {
                    if (i - 1 != j)
                    {

                        if (G.FindConnectedLink(j))
                        {
                            MW.Graph_datagrid[i, j].Value = "+";
                        }
                        else
                        {
                            MW.Graph_datagrid[i, j].Value = " ";
                        }
                    }
                }
            }

        }
        public void ReadFileFromWindows(StreamReader Reader1, MainWindow MW)
        {
            try { 
            while (!Reader1.EndOfStream)
            {
               
                string[] Converter = Reader1.ReadLine().Split(' ');
                Link link = new Link(Int32.Parse(Converter[0]), Int32.Parse(Converter[1]));
                All_Links.Add(link);
                DataGridUpd(MW);
            }
            Reader1.BaseStream.Seek(0, SeekOrigin.Begin);
            while (!Reader1.EndOfStream)
            {
                
                string[] Converter = Reader1.ReadLine().Split(' ');
                for (int i = 2; i < Converter.Length - 1; i++)
                {
                    if (!All_Links[Int32.Parse(Converter[0])].FindConnectedLink(Int32.Parse((Converter[i]))))
                        All_Links[Int32.Parse(Converter[0])].AddConnectedLink(GetLink(Int32.Parse((Converter[i]))));
                }
            }
            DataGridUpd2(MW);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Файл не может быть прочитан. Сообщение об ошибке: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

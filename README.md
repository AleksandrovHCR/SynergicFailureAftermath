Инструкция к программе:
1. Для начала работы нужно нажать иконку "Начать работу"
2. Создание графа происходит в окне "Добавить граф". (См. меню "программа") Если до этого был создан граф, то его можно загрузить.
3. Связи между узлами настраиваются в "Диспетчере узлов".
4. Созданый граф можно сохранить в файл с расширением .txt, базу данных (v 1.0.1 и выше) или использовать при моделировании (Пункт меню "Моделирование работы системы")
5. Моделирование работы можно провести вручную или автоматически. Для последнего нужно провести разбиения множества на подмножества (его результаты можно сохранить/загрузить).
6. После моделирования работы системы нужно посчитать последствия отказа для каждого из узлов(Так, чтобы получилось основное множество критических узлов из подмножеств). Это можно сделать вручную или автоматически(Не всегда срабатывает)
7. Как только в журнале результатов есть хотя бы одна запись, то дальше можно расчитать Синергетические последствия отказа.
Для компиляции программы v1.0.1 и выше требуется установить NuGet пакет System.Data.SQLite

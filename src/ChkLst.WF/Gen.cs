using ChkLst.Core;

namespace ChkLst.WF
{
    public static class Gen
    {
        public static CheckList CreateDefault()
        {
            var cl = new CheckList();

            var analize = new CheckItem() { Name = "Анализ" };
            var dev = new CheckItem() { Name = "Разработка" };
            var test = new CheckItem() { Name = "Тестирование" };
            var doc = new CheckItem() { Name = "Документирование" };

            cl.Root.Add(analize);
            cl.Root.Add(dev);
            cl.Root.Add(test);
            cl.Root.Add(doc);

            return cl;
        }
    }
}

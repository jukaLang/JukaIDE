using System.ComponentModel.DataAnnotations;

namespace JukaWebAssembly
{
    public class TabList
    {
        Queue<Tab> tabs = new();

        public int CurrentTab = 0;

        public TabList()
        {
            tabs.Enqueue(new Tab());
            CurrentTab = 0;
        }

        public Queue<Tab> List()
        {
            return tabs;
        }

        public void Add()
        {
            tabs.Enqueue(new Tab());
            CurrentTab = tabs.Count()-1;
        }

        public void Delete()
        {
            tabs.Dequeue();
        }

        public void Delete(int tab)
        {

        }

        public Tab getCurrentTab()
        {
            return tabs.ElementAt(CurrentTab);
        }
    }
}

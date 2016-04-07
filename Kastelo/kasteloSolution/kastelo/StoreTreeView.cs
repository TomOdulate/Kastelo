using System.Windows.Forms;

namespace Kastelo
{
    public class StoreNode : TreeNode
    {
        public StoreNode(StoreNode node)
        {
            Text = node.ToString(); //Or FriendlyName
            Node = node;
            //this.Node.Bars.ForEach(x => this.Nodes.Add(new BarNode(x)));
        }

        public StoreNode Node
        {
            get;
            private set;
        }
        
    }

    //public class BarNode : TreeNode
    //{
    //    public BarNode(Bar bar)
    //    {
    //        this.Text = bar.ToString(); //Or FriendlyName
    //        this.Bar = bar;
    //    }

    //    public Bar Bar
    //    {
    //        get;
    //        private set;
    //    }
    //}

}

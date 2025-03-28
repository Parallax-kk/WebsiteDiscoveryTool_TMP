using System.Collections.Generic;
using System.Windows.Forms;
using WebsiteDiscoveryTool;

public class SerializableTreeNode
{
    public string Text { get; set; }
    public PageData PageData { get; set; }
    public List<SerializableTreeNode> Nodes { get; set; } = new List<SerializableTreeNode>();

    public SerializableTreeNode() { }

    public SerializableTreeNode(TreeNode treeNode)
    {
        Text = treeNode.Text;
        PageData = (PageData)treeNode.Tag;
        foreach (TreeNode child in treeNode.Nodes)
        {
            Nodes.Add(new SerializableTreeNode(child));
        }
    }

    public TreeNode ToTreeNode()
    {
        TreeNode treeNode = new TreeNode(Text);
        foreach (SerializableTreeNode child in Nodes)
        {
            treeNode.Nodes.Add(child.ToTreeNode());
        }
        return treeNode;
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace demo_sort
{
    interface ISort
    {
        void LoadCode(bool tang);
        void Remove_Label();
        void Start(Node[] listNode);
    }
}

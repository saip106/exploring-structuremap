using System.Windows.Forms;
using Good.PresentationInterfaces;

namespace Good.PresentationLayer
{
    public partial class PeopleForm : Form
    {
        public PeopleForm(IPeopleService peopleService)
        {
            InitializeComponent();
            peopleListView.View = View.Details;

            foreach (var person in peopleService.GetAll())
            {
                peopleListView.Items.Add(new ListViewItem(new[] { person.Name }));
            }
        }
    }
}

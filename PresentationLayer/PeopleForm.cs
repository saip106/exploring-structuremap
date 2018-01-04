using System.Windows.Forms;
using BussinessLayer;

namespace PresentationLayer
{
    public partial class PeopleForm : Form
    {
        public PeopleForm()
        {
            InitializeComponent();
            peopleListView.View = View.Details;

            var peopleService = new PeopleService();
            foreach (var person in peopleService.GetAll())
            {
                peopleListView.Items.Add(new ListViewItem(new [] { person.Name }));
            }
        }
    }
}

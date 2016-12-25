using System.Linq;
using System.Windows.Controls;
using TiTsEd.ViewModel;

namespace TiTsEd.View {
    /// <summary>
    /// Interaction logic for RawPage.xaml
    /// </summary>
    public partial class RawPage : UserControl {
        public RawPage() {
            InitializeComponent();
            DisplayObjectGraph(VM.Instance.CurrentFile);
        }

        void DisplayObjectGraph(object graph) {
            var hierarchy = new ObjectViewModelHierarchy(graph);
            RawSaveStateTree.DataContext = hierarchy;
        }
    }
}

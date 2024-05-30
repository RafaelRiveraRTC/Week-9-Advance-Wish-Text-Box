using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week_9_Advance_Wish_Text_Box
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();




            // FlowDocument - Full Page - Collection of Paragraphs
            FlowDocument fd = new FlowDocument();

            rtbDisplay.Document = fd;

            //Paragraph - Colelction of sentences

            Paragraph firstParagraph = new Paragraph();

            //Run- Single Sentence 

            Run singleSentence = new Run("Single Sentences for Super Sentient Serpentines");
            singleSentence.FontStyle
            // Paragraph.InLines ios a collection you add a run to
            firstParagraph.Inlines.Add(singleSentence);

            //Flowdocument.Blocks is a collection you add a paragraph to 

            fd.Blocks.Add(firstParagraph);

        }// MainWindow




    }//class
}
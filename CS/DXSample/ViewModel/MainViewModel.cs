using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Linq;

namespace DXSample.ViewModel {
    [POCOViewModel]
    public class MainViewModel {
        protected IDocumentManagerService DocumentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public void CreateDocument() {
            IDocument doc = DocumentManagerService.CreateDocument("TabView", ViewModelSource.Create(()=> new TabViewModel()));
            doc.Id = String.Format("DocId_{0}", DocumentManagerService.Documents.Count());
            doc.Title = String.Format("Item {0}", DocumentManagerService.Documents.Count());
            doc.Show();
        }

        public void CloseDocument() {
            DocumentManagerService.ActiveDocument.Close();
        }
    }
}

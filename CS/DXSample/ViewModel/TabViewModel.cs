using DevExpress.Mvvm.DataAnnotations;
using System;

namespace DXSample.ViewModel {
    [POCOViewModel]
    public class TabViewModel {
        public virtual DateTime Updated { get; set; }
        public virtual object Content { get; set; }

        public TabViewModel() {
            Updated = DateTime.Now;
            Content = Guid.NewGuid();

        }
        public void UpdateDocument() {
            Updated = DateTime.Now;
            Content = Guid.NewGuid();
        }
    }
}

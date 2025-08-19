using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace NativeDarkMode_Lib
{
    public class DarkTabPageCollectionEditor : CollectionEditor
    {
        private IDesignerHost _host;
        private DarkTabControl _tabControl;

        public DarkTabPageCollectionEditor(Type type) : base(type) { }

        // We override EditValue to get a reference to the services and the control being edited.
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (context?.Instance is DarkTabControl tabControl)
            {
                _tabControl = tabControl;
                _host = (IDesignerHost)provider.GetService(typeof(IDesignerHost));
            }
            return base.EditValue(context, provider, value);
        }

        // <<< THIS IS THE FIX >>>
        // The correct method is CreateNewItemTypes() with an 's'.
        // This tells the "Add" button's dropdown what types it is allowed to create.
        protected override Type[] CreateNewItemTypes()
        {
            return new Type[] { typeof(DarkTabPage) };
        }

        // This override is called by the editor after the user chooses a type from the dropdown.
        protected override object CreateInstance(Type itemType)
        {
            if (itemType == typeof(DarkTabPage) && _host != null)
            {
                // Use the host to correctly create a new component.
                // This registers it with the designer and handles undo/redo.
                var newPage = (DarkTabPage)_host.CreateComponent(itemType);

                // We must wrap the adding of the control in a transaction.
                using (DesignerTransaction transaction = _host.CreateTransaction("Add DarkTabPage"))
                {
                    // Directly add the new page to the control's master Controls collection.
                    _tabControl?.Controls.Add(newPage);
                    newPage.Text = newPage.Name; // Give a default name.
                    transaction.Commit();
                }
                return newPage;
            }
            return base.CreateInstance(itemType);
        }

        // This override is called when the user clicks the "Remove" button.
        protected override void DestroyInstance(object instance)
        {
            if (_host != null && instance is IComponent component)
            {
                // Use the host to correctly destroy the component.
                using (DesignerTransaction transaction = _host.CreateTransaction("Remove DarkTabPage"))
                {
                    _host.DestroyComponent(component);
                    transaction.Commit();
                }
                return;
            }
            base.DestroyInstance(instance);
        }
    }
}

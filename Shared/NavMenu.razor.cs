using Microsoft.AspNetCore.Components;

namespace _4iConsultoria.Shared
{
    public partial class NavMenu
    {
        public bool dark;

        protected override void OnInitialized()
        {
            dark = false;
        }

        public bool ChangeTheme()
        {
            return (dark == false) ? dark = true : dark = false;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto08
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class Page4 : MasterDetailPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void btnPagi5_Clicked( object sender , EventArgs e )
        {
            Detail = new NavigationPage( new Page5() );
            IsPresented = false;
        }
    }
}
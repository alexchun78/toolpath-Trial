/*
  For Windows only:
  
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:ToolPathPainter"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  
  More details:
  See http://www.mvvmlight.net/installing/nuget
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ToolPathPainter.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            // [TO DO] 여기에 locator 등록
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<PolylineListViewModel>();
            SimpleIoc.Default.Register<CanvasFieldViewModel>();
            SimpleIoc.Default.Register<SliderSectionViewModel>();
            SimpleIoc.Default.Register<BasicControlSectionViewModel>();
            SimpleIoc.Default.Register<StatusBarSectionViewModel>();
            SimpleIoc.Default.Register<MainControlSectionViewModel>();
            SimpleIoc.Default.Register<PolylineListSectionViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }
        public PolylineListViewModel PolylineList
        {
            get
            {
                return SimpleIoc.Default.GetInstance<PolylineListViewModel>();
            }
        }

        public CanvasFieldViewModel CanvasField
        {
            get
            {
                return SimpleIoc.Default.GetInstance<CanvasFieldViewModel>();
            }
        }
        public SliderSectionViewModel sliderSection
        {
            get
            {
                return SimpleIoc.Default.GetInstance<SliderSectionViewModel>();
            }
        }
        public BasicControlSectionViewModel BasicControlSection
        {
            get
            {
                return SimpleIoc.Default.GetInstance<BasicControlSectionViewModel>();
            }
        }
        public StatusBarSectionViewModel StatusBarSection
        {
            get
            {
                return SimpleIoc.Default.GetInstance<StatusBarSectionViewModel>();
            }
        }
        public MainControlSectionViewModel MainControlSection
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainControlSectionViewModel>();
            }
        }
        public PolylineListSectionViewModel PolylineListSection
        {
            get
            {
                return SimpleIoc.Default.GetInstance<PolylineListSectionViewModel>();
            }
        }
    }
}
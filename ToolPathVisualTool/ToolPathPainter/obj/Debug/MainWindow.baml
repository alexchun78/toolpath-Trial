   M S B A M L   `   `   `  ����J  FToolPathPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ToolPathPainterToolPathPainter  5	      E'clr-namespace:ToolPathPainter.ViewModelToolPathPainter.ViewModel  5
      =#clr-namespace:ToolPathPainter.ViewsToolPathPainter.Views  5           ToolPathPainter.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      Bei9http://schemas.microsoft.com/expression/2010/interactions  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      )localclr-namespace:ToolPathPainter  5	      7	viewmodel'clr-namespace:ToolPathPainter.ViewModel  5
      .view#clr-namespace:ToolPathPainter.Views  5        � Title$  ToolPathPainter��5      $
��1280��5      $	��720��6    � WindowStartupLocation$ CenterScreen=�5      $
��1280��5      $	��720��6    � WindowStyle$
 None=�5       � DataContext 5      ��    Locator �� Source# [   �� Path$
 Main�.��5      � -   5         �Name$ g_LayoutRoot��5      .+�5   
   �� -   5         ��Name$ mainBackground��5       �� RadiusX$ 5��6,   	 �� RadiusY$	 5��68   
���������5      �� 5      
 �� EndPoint$
 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	LightGray��6#    � Offset$
 0.07Q�65   � 5      $ 	#FFFDFFFD��6#   5      5      � 5   
    � ColumnDefinitions 5      �� 5      $
��7.5* �6#   �� 5       $
��2.5* �6#   .+�5"      � $��0��6    � RowDefinitions 5#      �� 5$      $��23 �6$   �� 5%      �� 5&      $��50 �6$   .+�5(      � -   5        $ g_pathCanvasPart��5(      $��2��62   $��
5, 0, 2, 0q�6C   .+�5)      '   !ToolPathPainter.Views.CanvasField  5*      � 5+      -   5        $ g_basicControlPart��5+      $��2��63   $��0,4,0,0q�6@   .+�5,      /   )ToolPathPainter.Views.BasicControlSection  5-      � 5.      $��0,3,12,2q�6   .+�5/      ,   &ToolPathPainter.Views.StatusBarSection  50      51      � 52      $��1��6   $��
0, 0, 5, 5q�6#   .+�53      .   (ToolPathPainter.Views.MainControlSection  54      �� 55      -   5         ��Name$ g_rescaleWindowGrip��55      $��Bottom=�66   $��	-10,0,1,1q�6Q   $��9��6d   56      58      59      
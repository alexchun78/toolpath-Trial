   M S B A M L   `   `   `  ����J  FToolPathPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ToolPathPainter.ViewsToolPathPainter.Views  5      )    #ToolPathPainter.Views.SliderSection   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ToolPathPainter.Views     5        � DataContext  5      ��    Locator �� Source# [   �� Path$ CanvasField�.��5
      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6#   �� 5      $��* �6#   .+�5   
   �� -   5         ��Name$ sliderTimeLine��5      $��1��6*    � Minimum$ 0Q�6:    � Cursor$
 Hand��6F   {�.  $��	10,-1,5,0q�6f    � Value$ 0Q�6y   �� 5   
   -   5         ��Name$ stackPanel_Shadow��5      	 �� Orientation$	 
Horizontal=�60   $��11.313,5.341,0.935,3.629q�6I   .+�5      �� -   5        
 ��Name$
 txtCurrentTime1��5      $
��Wrap=�65   $��00:00:00��6I   $��Helvesegoe-normal)�6Y   
���   �$��11(�6�   �� 5      $
��Wrap=�6   $��/��60   $	��2,0q�69   $��Helvesegoe-normal)�6F   
���   �$��11(�6x   �� 5      -   5        $
 txtFullTime1��5      $
��Wrap=�62   $��00:00:00��6F   $��Helvesegoe-normal)�6V   
���   �$��11(�6�   5      �� 5   
   -   5        $ 
stackPanel��5      $��Center=�6)   $	 
Horizontal=�6F   $��5,0,0,0q�6_   $��Center=�6p   .+�5      �� -   5        $
 txtCurrentTime��5      $
��Wrap=�60   $��00:00:00��6D   $��Helvesegoe-normal)�6T   
��� ���$��11(�6�   �� 5      $
��Wrap=�6   $��/��6,   $	��2,0q�65   $��Helvesegoe-normal)�6B   
��� ���$��11(�6u   �� 5      -   5        $
 txtFullTime��5      $
��Wrap=�6-   $��00:00:00��6A   $��Helvesegoe-normal)�6Q   
��� ���$��11(�6�   5      5      5      
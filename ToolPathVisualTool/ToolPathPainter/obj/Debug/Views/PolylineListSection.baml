   M S B A M L   `   `   `  ����J  FToolPathPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ToolPathPainter.ViewsToolPathPainter.Views  5      /    )ToolPathPainter.Views.PolylineListSection   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ToolPathPainter.Views     5        � DataContext  5      ��    Locator �� Source# [   �� Path$ PolylineListSection�.��5
      �  � RowDefinitions 5   
   �� 5      $��23 �6   �� 5      .+�5   
   �� -   5         ��Name$ mediaBackground��5      $��2��6*   $��5,0,5,5q�6;   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF4E4E4E��6#    � Offset$ 1Q�65   � 5      $ White��6#   5      ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF2F2F2F��6#   $ 1Q�65   � 5      $ 	#FF414141��6#   5      5      � 5   
   -   5        	 �Name$	 	partVideo��5      $��
10,0,10,12q�6"   $��1��66   .+�5      �� -   5        $ bdVideo��5      ���	#FF606060$��1q�6>   $��1��6R   
���   �5&      5'      �� 5(   
   -   5        
 ��Name$
 
partWindow��5(      $��Right=�6)    �� Orientation$ 
Horizontal=�6E   $��0,3,13,3q�6^   ���	#00000000.+�5)      �� -   5         ��Name$ 	g_btnExit��5)      $��close��6(   $	��Top=�68   $��9(�6P   $
��Left=�6]   $��3,0,0,0q�6x   ��5*      �� *ExitCommand+5+      �� 5,   
   -   5         ��Name$ rGrip��5,      $��Bottom=�6$   $��Right=�6?   $��1��6[   $��0,0,2,2q�6h   5-      5.      
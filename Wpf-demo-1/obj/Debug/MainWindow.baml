   M S B A M L   `   `   `  ����E  AWpf-demo-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Wpf_demo_1
Wpf_demo_1  5   	       Wpf_demo_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Wpf_demo_1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��搜索条件：��6   $��Center=�6%   6B   �� 5      $	��200��6   $��25��6"   $��10 0 0 0q�6F   ��6.   �� *Search+6Z   �� 5      $��查找��6   $��70��6C   $��25��6N   $��10 0 0 0q�6Z   ��6"   �� *QueryCommand+6n   �� 5      $��重置��6   $��70��6C   $��25��6N   $��10 0 0 0q�6Z   ��6"   �� *ResetCommand+6n   �� 5      $��新增��6   $��70��6A   $��25��6L   $��10 0 0 0q�6X   ��6"   �� *
AddCommand+6l   �� 5      $��查找��6   $��70��6"   $��25��6-   $��10 0 0 0q�69   6M   5      &   System.Windows.Controls.DataGrid  5   
   $��1��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6       CanUserAddRows .     AutoGenerateColumns .  ��60   �� *GridModelList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 序号��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ 姓名��6%    61   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 操作��6)   	   CellTemplate	 5      �� 5      .R�5      �� $ 
Horizontal=�6)   .+�5   "   �� $��修改��6)   $��60��66   $��25��6A   
�������
���   ���5   )   �� *Id+��5    )   �� *DataContext.EditCommand+
 �� RelativeSource
 ��  �� Mode$ FindAncestor=� �� AncestorType$ DataGridL�6�   �� 5!   "   $��删除��6)   $��60��66   $��25��6A   
���  ��
���������5"   )   �� *Id+��5#   )   �� *DataContext.DelCommand+
 �� $ FindAncestor=�$ DataGridL�6�   5$      5%      5'      5)      5*      5+      
   M S B A M L   `   `   `  ����  TrainingAccounter*    $TrainingAccounter.WriteLicenseWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  许可写入��5   	   $	��300��6   $	��343��6#   $��12(�6/    � WindowState$ Normal=�6=    � WindowStartupLocation$ CenterScreen=�6R    � 
ResizeMode$ NoResize=�6w   .��5      � ���	#FF2E549D � ColumnDefinitions 5   
   �� 5      $
��219* �6   �� 5      $
��102* �6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGridWriteLicense��5
   i      AutoGenerateColumns .     CanUserAddRows .  $��12(�6F   $��10,12,12,12q�6T   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 盘 符��6<   	   
IsReadOnly	 . 
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 60 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *盘符+6[     5      $ 卷 标��6<   	 . $	
 120 6[    6%   �� *卷标+6[   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 写入许可��6)   $
 80 67      CellTemplate 5      �� 5      .R�5      �� $��btnWrite��6s   -   5           GlassButton#��[  5   <   $��写入许可��6d   6s   5      5      5      5      ��5      �� 5   
   5      
   M S B A M L   `   `   `  ����  TrainingAccounter#    TrainingAccounter.serRecharge   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  充值记录查询��5   	   $	��400��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V   .��5      � 
������.+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGridFinace��5   J   $
��Left=�6      AutoGenerateColumns .     CanUserAddRows .  $	��Top=�6x   $	��370��6�   $	��791��6�      SelectionMode$ Single=�6�   $��1,-2,0,0q�6�   $��14(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 身份证号码��6&      
IsReadOnly . 	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 6b   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6G   �� *PID_NO+6p     5	      $ 金额（元）��6%    . $		 100 6a   
 6F   �� *AMOUNT+6o     5
      $ 当前余额（元）��6%    . $		 110 6d   
 6H   �� *	BALANCE+6r     5      $ 充值日期��6%    . $		 200 6�   
 6E   �� *RECHARGE_TIME+ �� StringFormat$" {0:yyyy-MM-dd dddd HH:mm:ss}�� �� ConverterCulture$ zh-CN��6�     5      $ 	收款人��6%    . $		 100 6e   
 6D   �� *RECHARGE_PER+6s     5      $ 原因��6%    . $		 120 6^   
 6C   �� *REASON+6l   5      5      5      
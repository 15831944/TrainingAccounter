   M S B A M L   `   `   `  ����  TrainingAccounter'    !TrainingAccounter.UpdateBoxWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  提示消息：��5   	   $	��246��6   $	��450��6$    � WindowStartupLocation$ CenterScreen=�60   
����·� � 
ResizeMode$ NoResize=�6o   .��5      � $	��208��6   .+�5   
   � .+�5      ��  �� Orientation$ Vertical=�6   $	��443��60   .+�5	      �� $��71,0,0,0q�6   $ 
Horizontal=�6/   $
��Left=�6H   .+�5
      �� $��10,5,0,0q�6   .��6.   	姓名：63   �� 5      -   5        $��tbxName��5   b   $��14(�6    
���  ��{�.  $��0,5,0,0q�6Q   $	��100��6q   6   5      �� 5      $��36,0,0,0q�6   $ 
Horizontal=�6/   $
��Left=�6H   .+�5      �� $��10,5,0,0q�6   .��6.   身份证号码：66   �� 5      -   5        $��tbxPidNo��5   c   $��14(�6    {�.  
���  ��$��0,5,0,0q�6R   $	��150��6s   6�   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��10,5,0,0q�6   .��6/   本次预约实际训练：6:   �� 5      -   5        $��tbxActra��5   x   {�.  $��14(�60    �� TextAlignment$ Center=�6>   $��0,5,0,0q�6V   
���  ��$	��150��6�   6�   �� 5      -   5        $��	lbTratime��5      $��11(�6-   $��Bottom=�6;   
���  ��$�� ��6g   6u   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��35,5,0,0q�6   .��6.   本次训练费用：67   �� 5      -   5        $��tbxAcBalance��5   x   {�.  $��14(�60   $ Center=�6?   $��0,5,0,0q�6V   
���  ��$	��150��6�   6�   �� 5      $��11(�6   $��25��6*   $��Bottom=�66   
���  ��$��(元)��6b   6r   5      �� 5       $ 
Horizontal=�6   .+�5!      �� $��46,5,0,0q�6   .��6.   应结算金额：66   �� 5"      -   5        $��
tbxBalance��5"   x   {�.  $��0,5,0,0q�60   $ Center=�6B   $��14(�6Y   
���  ��$	��150��6�   6�   �� 5#      $��11(�6   $��25��6*   $��Bottom=�66   
���  ��$��(元)��6b   6r   5$      5%      5&      �� 5'   
   -   5        $��btnUpd��5'   �   $��结算完成��6      GlassButton#��[  6    $��18(�6H   $��35��6V   $
��Left=�6b   $��56,0,0,8q�6}   $��Bottom=�6�   $��89��6�   $��1��6�   �� 5(   
   -   5        $��	btnCancel��5(   h   $��取消结算��6   $��18(�6    #��[  6.   $��0,0,52,8q�6V   $��35��6�   $��Bottom=�6�   $��Right=�6�   $��89��6�   $��1��6�   5)      5*      
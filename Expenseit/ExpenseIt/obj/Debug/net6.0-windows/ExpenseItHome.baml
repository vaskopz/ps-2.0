   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseItHome   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - Home��5   	   $	��450��6"   $	��800��6/   .��5	      � $��
10,0,10,10q�6    � 	Resources 5
   
   ��%    5       � ColumnDefinitions 5   
   �� 5      �� 5      $	��300 �6   ��5   
   �� 5       �� ImageSource$ watermark.png��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��1��6   ��5      ��  �� RelativeSource ��  �� AncestorType" � �� Path$ MainCaptionText�6j   �� 5   
   $��1��6   $��1��6!   $��35��6.   $��	0,140,0,0q�6:    �� Padding$ 5q�6M   ���#4E87D4._�5      �� 
�������.��6'   Names6.   5      �� 5   
   -   5        $��0��5      $��1��6"   $��22,20,230,5q�6/   ��6D   �� $ PersonsChecked�6�   �� 5    
   -   5        $��peopleListBox��5       $��0��6'   $��
250,30,0,5q�67   $��2��6K   ��6�   ��  �� " �$ ExpenseDataSource���5#      �� 5$      .R�5%      �� ��6   �� $
 Name�5&      5)      �� 5+   
   -   5        $��	0,177,0,5q�5+      $��1��6%   $��2��65   $	��125��6B   $��25��6N   $��Right=�6Z   ��6�   �� 	 �� ElementName$	 peopleListBox��$ SelectedItem.Name�6�   �� 5,   
   $��65,29,315,125q�6   $��2��6(   $	��100��65   .��5-      �  5/      �� 50      �� 51      .+�53      �� $��0��6   $��Това е бутон��6%   �� 54      $��1��6   $
��ОК��6%   55      56      �� 57   
   $��0��6   $��2��6    $��0,171,192,0q�6R   ��6-   �� $ LastChecked�6R   58      59      
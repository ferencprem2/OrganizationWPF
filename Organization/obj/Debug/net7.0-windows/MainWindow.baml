   M S B A M L   `   `   `  ����G  COrganization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:OrganizationOrganization  5   	       Organization.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Organization     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgDatas��5         AutoGenerateColumns$ False��6$   $��0��6@   
���z���   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+  5      $ Country��6%    66   �� *	Country+  5      $ Founded��6%    66   �� *	Founded+  5      $ Industry��6%    67   �� *
Industry+  5      $ EmployeesNumber��6%    6>   �� *EmployeesNumber+5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      �� 5      .+�5"      �� -   5         ��Name$ 	cbCountry��5"      $��0��6*   6:   �� 5#      -   5        	 ��Name$	 BtndeleteCountrySelection��5#      $��1��68   $��Delete Selection��6H   6c   �� 5$      -   5        $ cbYear��5$      $��2��6'   
 �� SelectedIndex$
 -1��67   5&      � 5'   
   $��2��6    5(      �� 5)      �� 5*       5,      �� 5-      �� 5.      .+�50      �� -   5         ��Name$ labTotalEmpl��50      $��0��6*   
�������6:   �� 51      -   5        $ labID��51      $��1��6#   
�������63   �� 52      -   5        $ labWEB��52      $��1��6$   $��0��61   
�������6A   �� 53      -   5        $ labISM��53      $��1��6$   $��1��61   
�������6A   54      55      56      
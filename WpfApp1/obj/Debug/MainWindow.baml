   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Вариант 5��5   
   $	��250��6   $	��300��6)    � WindowStartupLocation$ CenterScreen=�5	   	   $��Comic Sans MS)�5
   	    � WindowStyle$ 
ToolWindow=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5!   
   �� $��Задание 1��6   $��0��5"      $��0��5#      $��2��5$      $��Center=�5%      $��Center=�5&      �� 5(   
   $��NN��6   $��1��5)      $��0��5*      $
��Left=�5+      $��Center=�5,      $��10q�5-      �� 5.   
   $��AA��6   $��2��5/      $��0��50      $
��Left=�51      $��Center=�52      $��10q�53      �� 54   
   $��BB��6   $��3��55      $��0��56      $
��Left=�57      $��Center=�58      $��10q�59      �� 5<   
   -   5         ��Name$ TextBlockAnswer��5<      $��Ответ:��5=      $��4��5>      $��0��5?      $��Stretch=�5@       �� Padding$
 10 0q�5A      $��Stretch=�5B      $��10q�5C      $��2��5D      �� 5E   
   -   5         ��Name$ 	TbNumberN��5E      $��1��5F      $��1��5G      $��Center=�5H      $
��10 0q�5I      $��1q�5J      �� 5K   
   -   5        $ 	TbNumberA��5K      $��2��5L      $��1��5M      $��Center=�5N      $
��10 0q�5O      $��1q�5P      �� 5Q   
   -   5        $ 	TbNumberB��5Q      $��3��5R      $��1��5S      $��Center=�5T      $
��10 0q�5U      $��1q�5V      �� 5Y   
   $��5��6   $��0��5Z      $��2��5[      	 �� Orientation$	 
Horizontal=�5\      $��Center=�5]      .+�5_      �� -   5        
 ��Name$
 BtnOK��5_      $��OK��6$   $��80��5`      $��24��6(   $��3q�64   
�������
�������5c      �� 5e      -   5        $
 	BtnCancel��5e      $��Cancel��6(   $��80��5f      $��24��6'   $��3q�63   
�������
�������5i      5j      5k      5l      
   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	   7 clr-namespace:booking.Componentsbooking.Components  68       booking.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	   7
components clr-namespace:booking.Components     68   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  Login��5	   
   $	��450��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�61   
������  � 
ResizeMode$ NoResize=�6p    � DataContext 5
      +  %booking.ViewModels.LoginPageViewModel  5   
   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 3��6   $��2��6&   ��5      �� 5      .��5      �  � Color$ 	#FF000611��6'   � 5      $ 	#FF1F32BD��6'    � Offset$	 0.5Q�69   � 5      $ 	#FF0D9080��6'   $ 1Q�69   5      5       �� 5#      $��Center=�6   .+�5$      �� $��Light"�5&      $��	helvetica)�5'      $��22(�5(      
�������$��Center=�5*      $��89��68   $
��68,0q�6D   $	��242��6R   �� 6_   $�          HOTEL��6c   $��Century)�6z   $��Normal"�6�   $��24(�6�   �� 6�   �� 6�   $�  Turquoise��6�   $��Cooper Black)�6�   $��36(�6�   6  5+      �� 5/      $��1��6   .+�50      ��  �� Orientation$ 
Horizontal=�6   .+�51      �� -   5        	 ��Name$	 email��51      $��	Helvetica)�6-   $��Light"�52      $��20(�54      $��Center=�55      
�������
������ $��0q�58      $	��235��59      $
��Left=�5:      
 J� Opacity$	
 0.5Q�5;      $��25��5<      $��	270,0,0,0q�5=      ��53      �� *LoginUsername+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5=      .  (MahApps.Metro.IconPacks.PackIconMaterial  5>         Kind$ Account=�61   $��Center=�5?   0   $��Center=�5@   0   
�������5A   0   5B      �� 5C      $	��250��6   $��2��5D      
�������$	
 0.5Q�5F      �� 5J      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5K      ,   &booking.Components.BindablePasswordBox  $��Light"�5L      $��20(�5N      $��Center=�5O      
�������
������ $��0q�5R      $	��235��5S      $
��Left=�5T      $	
 0.5Q�5U      $��25��5V      $��	270,0,0,0q�5W         Password 5X      �� *LoginPassword+$ TwoWay=�$ PropertyChanged=�  5Z      $ TextBox=�61   $��Center=�5[   0   $��Center=�5\   0   
�������5]   0   5^      �� 5_      $	��250��6   $��2��5`      
�������$	
 0.5Q�5b      �� 5e      $ 
Horizontal=�6   $��0,50,0,0q�66   $��Center=�6H   .+�5g      �� $	��138��6   $��40��6)   $��LOGIN��65   $��	30,0,60,0q�6E   $
��Bold"�6r   $��Trebuchet MS)�6�   $��16(�6�   
�����@���6X   �� *Login+6�   �� 5h      $	��138��6   $��40��6)   $��REGISTER��65   $��0,0,60,0q�6H   $��Trebuchet MS)�6w   $
��Bold"�6�   $��16(�6�   
�����@���6Z   �� *
Register+6�   �� 5i      $	��138��6   $��40��6)   $��JOIN AS GUEST��65   $��0,0,0,0q�6M   $��Trebuchet MS)�6   $��16(�6�   $
��Bold"�6�   
�����@���6^   �� *LoginAsGuest+6�   5k      5m      5o      5p      5r      
   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	   7 clr-namespace:booking.Componentsbooking.Components  68        booking.Views.RegisterPage   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	   7
components clr-namespace:booking.Components     68     � Title$  Register Page��5   	   
 � Top$	 280��6    � Left$	 550��6)   $	��350��65   $	��450��6B    � WindowStartupLocation$ CenterScreen=�6N    � DataContext 5	      .  (booking.ViewModels.RegisterPageViewModel  5
   
   .��5      � 
�����@�.+�5   
   �� $��Center=�6   $��Create a new account��61   $��0,20,0,0q�6M   $��22(�6_   $
��Wrap=�6m   $	��Top=�6�   $��Trebuchet MS)�6�   �� 5   
   $
��Left=�6   $��	14,74,0,0q�6/   $��	Username:��6B   $
��Wrap=�6S   $	��Top=�6g   $��Trebuchet MS)�6   $
��Bold"�6�   $��16(�6�   �� 5   
   $
��Left=�6   $��
108,74,0,0q�6-    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��250��6�   $��19��6�   $��Trebuchet MS)�6�   $��14(�6�   ��6A   �� *UserNameInput+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
14,125,0,0q�6/   $��	Password:��6C   $
��Wrap=�6T   $	��Top=�6h   $��Trebuchet MS)�6�   $��16(�6�   $
��Bold"�6�   ,   &booking.Components.BindablePasswordBox  5   
   $
��Left=�6)   $��108,125,0,0q�6D   $	��Top=�6�   $	��250��6�      Password 6Y   �� *PasswordInput+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5        $��Register��5      $
��Left=�6$   $��183,264,0,0q�6?   $	��Top=�6T   $	��100��6l   $��Trebuchet MS)�6�   $
��Bold"�6�   $��16(�6�   
���������6x   �� *RegisterUser+6�   �� 5   
   $
��Left=�6   $��108,169,0,0q�6.   $	��Top=�6C   $	��250��6[   	 �� SelectedValue	 6g   �� *	RoleInput+$ TwoWay=�$ PropertyChanged=�.@�5      �� $��Administrator��6   �� 5      $��
Utilizator��6   �� 5      $��Angajat��6   5      �� 5   
   $
��Left=�6   $��
14,172,0,0q�6/   $
��Rol:��6C   $
��Wrap=�6O   $	��Top=�6c   $��Trebuchet MS)�6{   $
��Bold"�6�   $��16(�6�   5      5      
   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	   7 clr-namespace:booking.Componentsbooking.Components  68        booking.Views.RegisterPage   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	   7
components clr-namespace:booking.Components     68     � Title$  Register Page��5   	   $	��350��6   $	��450��6,    � DataContext 5	      .  (booking.ViewModels.RegisterPageViewModel  5
   
   .��5      � .+�5   
   �� $��Center=�6   $��Creaza un cont nou��61   $��0,20,0,0q�6K   $��22(�6]   $
��Wrap=�6k   $	��Top=�6   �� 5   
   $
��Left=�6   $��	40,75,0,0q�6/   $��	Username:��6B   $
��Wrap=�6S   $	��Top=�6g   �� 5   
   $��Center=�6   $��	15,75,0,0q�6/    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��250��6�   ��6B   �� *UserNameInput+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
40,125,0,0q�6/   $��	Password:��6C   $
��Wrap=�6T   $	��Top=�6h   ,   &booking.Components.BindablePasswordBox  5   
   $��Center=�6)   $��
15,125,0,0q�6F   $	��Top=�6�   $	��250��6�      Password 6Z   �� *PasswordInput+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5        $��Register��5      $��Center=�6$   $��	0,275,0,0q�6A   $	��Top=�6T   $	��100��6l   ��6x   �� *RegisterUser+6�   �� 5   
   $
��Left=�6   $��100,169,0,0q�6.   $	��Top=�6C   $	��250��6[    �� SelectedValue 6g   �� *	RoleInput+$ TwoWay=�$ PropertyChanged=�.@�5      �� $��Administrator��6   �� 5      $��
Utilizator��6   �� 5      $��Angajat��6   5      �� 5   
   $
��Left=�6   $��
45,173,0,0q�6/   $
��Rol:��6C   $
��Wrap=�6O   $	��Top=�6c   5      5      
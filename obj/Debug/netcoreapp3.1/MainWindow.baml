   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	   7 clr-namespace:booking.Componentsbooking.Components  68       booking.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	   7
components clr-namespace:booking.Components     68     � Title$  Welcome Page��5   	   $	��425��6   $	��500��6+    � DataContext 5	      +  %booking.ViewModels.LoginPageViewModel  5
   
   .��5      � .+�5   
   �� $.��(Bine ati venit la hotelul 'Steaua marii'��6   $��25(�6C   $��Center=�6Q   $	��Top=�6n   $
��0,25q�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $	��Top=�6-   $��130,125,0,0q�6E    �� TextWrapping$
 Wrap=�6�   $	��300��6�   ��6[   �� *LoginUsername+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
55,125,0,0q�6/   $��	Username:��6C   $
��Wrap=�6T   $	��Top=�6h   ,   &booking.Components.BindablePasswordBox  5   
   $
��Left=�6)   $	��Top=�6D   $��130,175,0,0q�6\   $	��300��6�      Password 6r   �� *LoginPassword+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
55,175,0,0q�6/   $��	Password:��6C   $
��Wrap=�6T   $	��Top=�6h   �� 5   
   $��Login��6   $��Center=�6!   $	��Top=�6>   $��	0,225,0,0q�6V   $	��100��6i   ��6u   �� *Login+�� 5   
   $��Login as guest��6   $��Center=�6*   $	��Top=�6G   $��	0,265,0,0q�6_   $	��100��6r   ��6~   �� *LoginAsGuest+�� 5   
   $��Center=�6   $	��Top=�61   $��	0,325,0,0q�6I   $B��<Daca doriti sa va faceti cont, apasati pe butonul de mai jos��6\   $��12(�6�   $
��Wrap=�6�   �� 5   
   $��Register��6   $��Center=�6$   $	��Top=�6A   $��	0,350,0,0q�6Y   $	��100��6l   ��6x   �� *
Register+5      5      
   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	       booking.Views.ClientPage   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	     � Title$  Client Page��5   	   $	��450��6   $	��800��6*    � WindowState$ 	Maximized=�66    � DataContext 5	      ,  &booking.ViewModels.ClientPageViewModel  5
   
   .��5      � .+�5   
   �� .+�5      �� $5��/C:\Users\User\Desktop\booking\Images\hotel2.jpg��6   6O   5      �� 5   
   $��
0,0,-0.4,0q�6    J� RenderTransformOrigin$ 0.506,0.497&�6)   $��3��6M   .+�5      o�  o� 
IsMainMenu$
 True��6   
�����@�$��25��6=   $��
0,0,-0.4,0q�6I   $	��Top=�6]   $��Stretch=�6u   .@�5      m� $��Oferte��6   $��Comic Sans MS Bold)�6+   $��25��6M   .@�5      m� $��Vizualizare oferte��6    m� Command 6;   ��  �� Path$ 
ViewOffers�5      m� 5      $��	Rezervari��6   $��Comic Sans MS Bold)�6.   $��25��6P   .@�5      m� $��Adauga rezervare��6    69   �� $ AddRezervation��� 5      m� 5      $��Istoric rezervari��6    6:   �� $ ViewRezervations�5      m� 5!      $��Camere��6   $��Comic Sans MS Bold)�6+   $��25��6M   .@�5"      m� $��Tipuri de camere��6    69   �� $ 	ViewRooms�5#      5%      5&      �� 5'   
   -   5        $��Deconectare��5'      $	��250��6'   $��70��63   $��Center=�6?   $��Bottom=�6\   
�����@�$��Trebuchet MS)�6�   $��22(�6�   $
��Bold"�6�   6�   �� 5(   
   $��   Client mode��6   $
��Wrap=�6*   $
��Bold"�6>   $��36(�6P   $	��252��6^   $��-389,53,937,321q�6j   $��Trebuchet MS)�6�   5*      5+      
   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	       booking.Views.AdminPage   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	     � Title$  
Admin Page��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�65    � DataContext 5	      +  %booking.ViewModels.AdminPageViewModel  5
   
   .��5      � .+�5   
   �� .+�5      �� $5��/C:\Users\User\Desktop\booking\Images\hotel2.jpg��6   6O   5      �� 5   
   $��
0,0,-0.4,0q�6    J� RenderTransformOrigin$ 0.506,0.497&�6)   $��3��6M   .+�5      o�  o� 
IsMainMenu$
 True��6   
�����@�$��25��6=   $��
0,0,-0.4,0q�6I   $	��Top=�6]   $��Stretch=�6u   .@�5      m� $��Dotari��6   $��Comic Sans MS Bold)�6+   $��25��6M   .@�5      m� $��Adauga dotare��6     m� Command 67   ��  �� Path$ 
AddFeature��� 5      m� 5      $��Sterge dotare��6    66   �� $ RemoveFeature�5      m� 5      $��Camere��6   $��Comic Sans MS Bold)�6+   $��25��6M   .@�5      m� $��Adauga camera��6     67   �� $ AddRoom��� 5      m� 5      $��Sterge camera��6    66   �� $ 
RemoveRoom�5       m� 5"      $��Servicii��6   $��Comic Sans MS Bold)�6-   $��25��6O   .@�5#      m� $��Adauga serviciu��6     69   �� $ 
AddService��� 5$      m� 5%      $��Vizualizare servicii��6    6=   �� $ ViewServices��� 5&      m� 5'      $��Sterge serviciu��6    68   �� $ RemoveService�5)      m� 5+      $��Oferte��6   $��Comic Sans MS Bold)�6+   $��25��6M   .@�5,      m� $��Adauga oferta��6     67   �� $ AddOffer��� 5.      m� 5/      $��Vizualizare oferte��6    6;   �� $ 
ViewOffers��� 50      m� 51      $��Sterge oferta��6    66   �� $ RemoveOffer�53      m� 55      $��Preturi��6   $��Comic Sans MS Bold)�6,   $��25��6N   .@�56      m� $��Adauga pret��6     65   �� $ AddPrice��� 58      m� 59      $��Sterge pret��6    64   �� $ RemovePrice�5:      5<      5=      �� 5>   
   -   5        $��Deconectare��5>      $	��250��6'   $��70��63   $��Center=�6?   $��Bottom=�6\   
�����@�$��Trebuchet MS)�6�   $��22(�6�   $
��Bold"�6�   6�   �� 5?   
   $��   Admin mode��6   $
��Wrap=�6)   $
��Bold"�6=   $��36(�6O   $	��252��6]   $��-389,53,937,321q�6i   $��Trebuchet MS)�6�   5@      5A      
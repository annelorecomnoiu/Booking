   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	       booking.Views.AdminPage   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	     � Title$  
Admin Page��5   	   $	��900��6   $
��1600��6)    � DataContext 5	      +  %booking.ViewModels.AdminPageViewModel  5
   
   .��5      � .+�5   
   �� $
��Left=�6   $��	25,25,0,0q�6/   $��
Admin mode��6B   $
��Wrap=�6T   $	��Top=�6h   $
��Bold"�6�   $��36(�6�   �� 5   
   $��Adauga dotare��6   $
��Left=�6)   $��
300,40,0,0q�6D   $	��Top=�6X   $	��150��6p   $��35��6|   $��16(�6�   ��6�   ��  �� Path$ 
AddFeature��� 5   
   $��Sterge dotare��6   $
��Left=�6)   $��300,100,0,0q�6D   $	��Top=�6Y   $	��150��6q   $��35��6}   $��16(�6�   ��6�   �� $ RemoveFeature��� 5   
   $��Adauga camera��6   $
��Left=�6)   $��
500,40,0,0q�6D   $	��Top=�6X   $	��150��6p   $��35��6|   $��16(�6�   ��6�   �� $ AddRoom��� 5   
   $��Sterge camera��6   $
��Left=�6)   $��500,100,0,0q�6D   $	��Top=�6Y   $	��150��6q   $��35��6}   $��16(�6�   ��6�   �� $ 
RemoveRoom��� 5   
   $��Editeaza camera��6   $
��Left=�6+   $��500,160,0,0q�6F   $	��Top=�6[   $	��150��6s   $��35��6   $��16(�6�   �� 5   
   $��Adauga serviciu��6   $
��Left=�6+   $��
700,40,0,0q�6F   $	��Top=�6Z   $	��150��6r   $��35��6~   $��16(�6�   ��6�   �� $ 
AddService��� 5   
   $��Sterge serviciu��6   $
��Left=�6+   $��700,100,0,0q�6F   $	��Top=�6[   $	��150��6s   $��35��6   $��16(�6�   ��6�   �� $ RemoveService��� 5   
   $��Adauga oferta��6   $
��Left=�6)   $��
900,40,0,0q�6D   $	��Top=�6X   $	��150��6p   $��35��6|   $��16(�6�   ��6�   �� $ AddOffer��� 5   
   $��Sterge oferta��6   $
��Left=�6)   $��900,100,0,0q�6D   $	��Top=�6Y   $	��150��6q   $��35��6}   $��16(�6�   ��6�   �� $ RemoveOffer��� 5   
   $��Editeaza oferta��6   $
��Left=�6+   $��900,160,0,0q�6F   $	��Top=�6[   $	��150��6s   $��35��6   $��16(�6�   �� 5   
   $��Adauga pret��6   $
��Left=�6'   $��1100,40,0,0q�6B   $	��Top=�6W   $	��150��6o   $��35��6{   $��16(�6�   ��6�   �� $ AddPrice��� 5   
   $��Sterge pret��6   $
��Left=�6'   $��1100,100,0,0q�6B   $	��Top=�6X   $	��150��6p   $��35��6|   $��16(�6�   ��6�   �� $ RemovePrice��� 5   
   $��Editeaza pret��6   $
��Left=�6)   $��1100,160,0,0q�6D   $	��Top=�6Z   $	��150��6r   $��35��6~   $��16(�6�   �� 5    
   $��Vizualizare oferte��6   $
��Left=�6.   $��1300,40,0,0q�6I   $	��Top=�6^   $	��150��6v   $��35��6�   $��16(�6�   ��6�   �� $ 
ViewOffers��� 5!   
   $��Vizualizare servicii��6   $
��Left=�60   $��1300,100,0,0q�6K   $	��Top=�6a   $	��150��6y   $��35��6�   $��16(�6�   ��6�   �� $ ViewServices��� 5"   
   $��Center=�6   $	��464��61   
���   �$	��Top=�6M   $
��1084��6e   $��	0,300,0,0q�6r   5%      5&      
   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	        booking.Views.AddOfferPage   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	     � Title$  	Add Offer��5   	   $	��465��6   $	��315��6(    � DataContext 5	      *  $booking.ViewModels.AddOfferViewModel  5
   
   .��5      � .+�5   
   �� $
��Left=�6   $��	40,25,0,0q�6/   $��Nume oferta:��6B   $
��Wrap=�6V   $	��Top=�6j   �� 5   
   $
��Left=�6   $��
125,25,0,0q�6-    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6A   �� *	OfferName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��	40,65,0,0q�6/   $��Pret:��6B   $
��Wrap=�6O   $	��Top=�6c   �� 5   
   -   5        $��NumarCamere��5      $
��Left=�6%   $��
125,65,0,0q�6@   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6T   �� *
PriceValue+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
40,105,0,0q�6/   $��Camera:��6C   $
��Wrap=�6R   $	��Top=�6f   �� 5   
   $
��Left=�6   $��125,105,0,0q�6.   $	��Top=�6C   $	��150��6[   ��6g   �� *Camere+ �� SelectedValue 6�   �� *SelectedCamera+$ TwoWay=�$ PropertyChanged=��� 5   
   $
��Left=�6   $��
40,145,0,0q�6/   $��Data inceput:��6C   $
��Wrap=�6X   $	��Top=�6l   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��125,145,0,0q�60   $	��Top=�6E   $	��150��6]      SelectedDate 6i   �� *	StartDate+$ TwoWay=�$ PropertyChanged=��� 5   
   $
��Left=�6   $��
40,185,0,0q�6/   $��Data sfarsit:��6C   $
��Wrap=�6X   $	��Top=�6l     5   
   $
��Left=�6   $��125,185,0,0q�60   $	��Top=�6E   $	��150��6]    6i   �� *	EndDate+$ TwoWay=�$ PropertyChanged=��� 5   
   $
��Left=�6   $��
40,230,0,0q�6/   $��Servicii posibile:��6C   $
��Wrap=�6]   $	��Top=�6q   �� 5   
   $
��Left=�6   $��130,230,0,0q�6.   $	��Top=�6C   $	��150��6[   ��6g   �� *ServiciiOferta+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 6�   �� *CurrentNewService+$ TwoWay=�$ PropertyChanged=��� 5   
   $��Adauga serviciu��6   $��Center=�6+   $��	0,275,0,0q�6H   $	��Top=�6[   $	��100��6s   ��6   ��  �� Path$ 
AddService��� 5    
   $
��Left=�6   $��
40,315,0,0q�6/   $��Servicii selectate:��6C   $
��Wrap=�6^   $	��Top=�6r   �� 5!   
   $
��Left=�6   $��135,315,0,0q�6.   $	��Top=�6C   $	��150��6[   ��6g   �� *ServiciiAdaugate+$ TwoWay=�$ PropertyChanged=� 6�   �� *CurrentAddedService+$ TwoWay=�$ PropertyChanged=��� 5"   
   $��Sterge serviciu��6   $��Center=�6+   $��	0,355,0,0q�6H   $	��Top=�6[   $	��100��6s   ��6   �� $ RemoveService��� 5$   
   -   5        $��Adauga camera��5$      $��Center=�6)   $��	0,400,0,0q�6F   $	��Top=�6Y   $	��100��6q   ��6�   �� $ AddOffer�5%      5&      
   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	   #    booking.Views.RemovePricePage   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	     � Title$  RemovePricePage��5   	   $	��300��6!   $	��300��6.    � DataContext 5	      -  'booking.ViewModels.RemovePriceViewModel  5
   
   .��5      � .+�5   
   �� $
��Left=�6   $��
121,47,0,0q�6.   $	��Top=�6B   $	��150��6Z   ��6f   �� *	Preturi+ �� SelectedItem 6�   �� *SelectedPret+�� 5   
   $
��Left=�6   $��	20,50,0,0q�6/   $��Alege pretul:��6B   $
��Wrap=�6W   $	��Top=�6k   �� 5   
   $
��Left=�6   $��	20,80,0,0q�6/   $��Nume camera:��6B   $
��Wrap=�6V   $	��Top=�6j   �� 5   
   $
��Left=�6   $��
120,80,0,0q�6/   $
��Wrap=�6�   $	��Top=�6�   ��6C   �� *
RoomName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
20,110,0,0q�6/   $��Data start:��6C   $
��Wrap=�6V   $	��Top=�6j   �� 5   
   $
��Left=�6   $��120,110,0,0q�6/   $
��Wrap=�6�   $	��Top=�6�   ��6D   �� *	DateStart+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
20,140,0,0q�6/   $��	Data end:��6C   $
��Wrap=�6T   $	��Top=�6h   �� 5   
   $
��Left=�6   $��120,140,0,0q�6/   $
��Wrap=�6�   $	��Top=�6�   ��6D   �� *	DateEnd+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
20,170,0,0q�6/   $��Pret:��6C   $
��Wrap=�6P   $	��Top=�6d   �� 5   
   $
��Left=�6   $��120,170,0,0q�6/   $
��Wrap=�6�   $	��Top=�6�   ��6D   �� *
PriceValue+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5        $��Sterge pret��5      $��Center=�6'   $��	0,175,0,0q�6D   $��Center=�6W   $	��125��6r   ��6�   ��  �� Path$ RemovePrice�5      5      
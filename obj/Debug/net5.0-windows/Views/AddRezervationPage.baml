   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	   7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	   &     booking.Views.AddRezervationPage   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	   3local2 clr-namespace:booking.ViewModels     5   	     � Title$  AddRezervationPage��5	   	   $	��460��6$   $	��355��61    � WindowStartupLocation$ CenterScreen=�6=    � DataContext 5
      0  *booking.ViewModels.AddRezervationViewModel  5   
   .��5      � 
�����@�.+�5   
   �� $
��Left=�6   $��	40,25,0,0q�6/   $��Camera:��6B   $
��Wrap=�6Q   $	��Top=�6e   �� 5   
   $
��Left=�6   $��
125,25,0,0q�6.   $	��Top=�6B   $	��150��6Z   ��6f   �� *Camere+ �� SelectedValue 6�   �� *SelectedCamera+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $
��Left=�6   $��	40,65,0,0q�6/   $��
Nr camere:��6B   $
��Wrap=�6T   $	��Top=�6h   $��69��6�   �� 5   
   $
��Left=�6   $��
125,63,0,0q�6-    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��124��6�   ��6A   �� *
NrCamere+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
40,107,0,0q�6/   $��Data start:��6C   $
��Wrap=�6V   $	��Top=�6j   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��125,107,0,0q�60   $	��Top=�6E      SelectedDate 6]   �� *	StartDate+$ TwoWay=�$ PropertyChanged=��� 5   
   $
��Left=�6   $��
40,148,0,0q�6/   $��	Data end:��6C   $
��Wrap=�6T   $	��Top=�6h     5   
   $
��Left=�6   $��125,148,0,0q�60   $	��Top=�6E    6]   �� *	EndDate+$ TwoWay=�$ PropertyChanged=��� 5   
   $
��Left=�6   $��
38,183,0,0q�6/   $��Oferta:��6C   $
��Wrap=�6R   $	��Top=�6f   �� 5   
   $
��Left=�6   $��125,183,0,0q�6.   $	��Top=�6C   $	��150��6[   ��6g   �� *Oferte+ 6�   �� *SelectedOffer+$ TwoWay=�$ PropertyChanged=��� 5    
   $
��Left=�6   $��
36,220,0,0q�6/   $��Servicii camera:��6C   $
��Wrap=�6[   $	��Top=�6o   �� 5!   
   $
��Left=�6   $��125,217,0,0q�6.   $	��Top=�6C   $	��150��6[   ��6g   �� *ServiciiRezervare+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 6�   �� *CurrentNewService+$ TwoWay=�$ PropertyChanged=��� 5#   
   $��Adauga serviciu��6   $
��Left=�6+   $��150,244,0,0q�6F   $	��Top=�6[   $	��100��6s   
���������6�   �� 	 �� Path$	 
AddService��� 5&   
   $
��Left=�6   $��
32,286,0,0q�6/   $��Servicii selectate:��6C   $
��Wrap=�6^   $	��Top=�6r   �� 5'   
   $
��Left=�6   $��125,280,0,0q�6.   $	��Top=�6C   $	��150��6[   ��6h   �� *ServiciiAdaugate+$ TwoWay=�$ PropertyChanged=� 6�   �� *CurrentAddedService+$ TwoWay=�$ PropertyChanged=��� 5)   
   $��Sterge serviciu��6   $
��Left=�6+   $��153,307,0,0q�6F   $	��Top=�6[   $	��100��6s   
���������6�   �� $	 RemoveService��� 5+   
   -   5        $��Adauga rezervare��5+      $
��Left=�6,   $��143,377,0,0q�6G   $	��Top=�6\   $	��114��6t   
�������$��30��6�   ��6�   �� $	 AddRezervation�5-      5.      
   M S B A M L   `   `   `  ����F  BEjercicio10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Ejercicio10Ejercicio10  5   	   $    Ejercicio10.PrediccionesWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Ejercicio10     5   	   -   5          �Name$  Predicciones��5   	    � Title$ Predicciones��5   	   $	��640��6   $	��360��6+   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $	��120 �6   6+   �� 5      $	��350 �6   6+   �� 5      $��40 �6   6*   .+�5   
   �� -   5         ��Name$ localizacionTextBlock��5      $
��Left=�63   $��5q�6N   $
��Wrap=�6Y   $��Localización: Ourense��6m   $��Center=�6�   $��0��6�   $��2��6�   $��0��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ fechaDatePicker��5      $
��Left=�6.   $��5q�6I   $��Center=�6T   $��0��6o   $��1��6   �� 5   
   -   5         ��Name$ consultarButton��5      $��	Consultar��6*   $
��Left=�6>   $��5q�6Y   $��Center=�6d   $��75��6   $��1��6�   $��1��6�   6�   �� 5   
   $��8q�6   $��Temperatura��6   $	��300��63   $��0��6?   $��2��6O   $��2��6c    � IsSharedSizeScope . .��5      �� $	��100��6   ._�5      �� .+�5      �� -   5        $ mananaTextBlock��5       $
��Left=�69   $��5q�6T   $
��Wrap=�6_   $��Mañana:��6s   $	��Top=�6�   �� 5      -   5        $ tardeTextBlock��5       $
��Left=�68   $��5q�6S   $
��Wrap=�6^   $��Tarde:��6r   $	��Top=�6�   �� 5       -   5        $ nocheTextBlock��5        $
��Left=�68   $��5q�6S   $
��Wrap=�6^   $��Noche:��6r   $	��Top=�6�   5!      5"      5#      �� 5%   
   $��10q�6   $��
Pronostico��6   $	��300��64   $��0��6@   $��2��6P   $��3��6d   .��5&      �� $	��300��6   ._�5'      �� .+�5(      �� $��5q�6   $��Viento mínimo��6*   $	��270��6A   .��5)      �� $	��120��6!   ._�5*      �� .+�5+   "   �� -   5        $ gradoMinTextBlock��5+   ,   $
��Left=�6G   $��5q�6b   $
��Wrap=�6m   $��Grado:��6�   $	��Top=�6�   �� 5,   "   -	   5        $ denominacionMinTextBlock��5,   ,   $
��Left=�6N   $��5q�6i   $
��Wrap=�6t   $��Denominación:��6�   $	��Top=�6�   �� 5-   "   -
   5        $ efectoTierraMinTextBlock��5-   ,   $
��Left=�6N   $��5q�6i   $
��Wrap=�6t   $��Efecto en tierra:��6�   $	��Top=�6�   5.      5/      50      �� 51      $��3q�6   $��Viento máximo��6*   $	��270��6A   .��52      �� $	��120��6!   ._�53      �� .+�54   "   �� -   5        $ gradoMaxTextBlock��54   ,   $
��Left=�6G   $��5q�6b   $
��Wrap=�6m   $��Grado:��6�   $	��Top=�6�   �� 55   "   -   5        $ denominacionMaxTextBlock��55   ,   $
��Left=�6N   $��5q�6i   $
��Wrap=�6t   $��Denominación:��6�   $	��Top=�6�   �� 56   "   -   5        $ efectoTierraMaxTextBlock��56   ,   $
��Left=�6N   $��5q�6i   $
��Wrap=�6t   $��Efecto en tierra:��6�   $	��Top=�6�   57      58      59      5:      5;      5<      �� 5>   
   -   5        $ guardarButton��5>      $��Guardar��6(   $��Center=�6:   $��5q�6W   $	��Top=�6b   $��75��6z   $��0��6�   $��2��6�   $��4��6�   6�   5@      5A      
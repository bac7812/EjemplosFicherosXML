   M S B A M L   `   `   `  ����E  AEjercicio7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Ejercicio7
Ejercicio7  5   	   !    Ejercicio7.ClasificarWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Ejercicio7     5   	   -   5          �Name$  Clasificación��5   	    � Title$ Clasificación��5   	   $	��375��6   $	��550��6,   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      6   .+�5   
   �� -   5         ��Name$ TituloTemporadaTextBlock��5      $��Right=�66   $��5q�6R   $
��Wrap=�6]   $��
Temporada:��6q   $	��Top=�6�   $��0��6�   $��0��6�   �� 5   
   -   5        $ NumTemporadaTextBlock��5      $
��Left=�63   $��5q�6N   $
��Wrap=�6Y   $�� ��6m   $	��Top=�6u   $��1��6�   $��0��6�   �� 5   
   -   5        $( "consultarTemporadaEquiposTextBlock��5      $
��Left=�6@   $��5q�6[   $
��Wrap=�6f   $ ��Clasificar los resultados:��6z   $��Center=�6�   $��0��6�   $��2��6�   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DatosDataGrid��5      $��Center=�6*   $��5q�6G   $��Center=�6R   $	��500��6n   $	��220��6z   $��0��6�   $��2��6�   $��2��6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *partidoNombre+  5      $ Puntos��6%   	 65   �� *partidoPuntos+  5      $ Jugados��6%   	 66   �� *partidoJugados+  5      $ Ganados��6%   	 66   �� *partidoGanados+  5      $ 	Empatados��6%   	 68   �� *partidoEmpatados+  5      $ Pedidos��6%   	 66   �� *partidoPerdidos+5!      5"      5#      
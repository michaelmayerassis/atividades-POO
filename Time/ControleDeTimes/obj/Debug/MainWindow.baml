   M S B A M L   `   `   `  ����J  FControleDeTimes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ControleDeTimesControleDeTimes  5   	        ControleDeTimes.MainWindow   5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ControleDeTimes     5   	   $	��800��5
   	   $
��1200��6     � WindowStyle$
  None=�6#   $��0q�66    � WindowStartupLocation$ CenterScreen=�6J    � WindowState$ 	Maximized=�6o    � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 50Q�63     5      $ 0:0:0.2��6'   $	 230Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 230Q�63     5      $ 0:0:0.2��6'   $ 50Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5       �� #��[ 6   5!      .��5$      � .+�5&   
   � $��80��6   $	��Top=�6   .+�5'      �� -   5         ��Name$ btnFecharAplicacao��5'      $	��Top=�61   $��Right=�6I   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6	  ��6e   Z� ��6{   Z� .��5(      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ fechar��5(   *   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6:   
���   �5)   )   5*      5+      � 5,   
   -   5         �Name$ GridPrincipal��5,      $��Center=�6&   $��Center=�6C   $	��800��5-      $
��1112��6   $��55,28,25,22q�6)    � RowDefinitions 5/      �� 50      $
��627* �6    �� 51      $
��173* �6    .+�53      &   System.Windows.Controls.DataGrid  -   5          Name$ dgListar��53         
IsReadOnly . $
��Left=�6;   $	��239��6V   $��-11,161,0,0q�6c   $	��Top=�6x   $
��1088��6�   ���	#890000006�   �� 54      $��Nome do Tme:��6   $
��Left=�6+   $��189,105,0,0q�6F   $	��Top=�6[    J� RenderTransformOrigin$ -0.273,1.692&�6s   $	��180��6�   �� 55      -   5         ��Name$ txtNome��55      $
��Left=�6'   $��41��6B   $��
373,93,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6w   $	��394��6�   $��24(�6�   �� 56      $��Qtd.Titulos:��6   $
��Left=�6+   $��781,107,0,0q�6F   $	��Top=�6[   $ -0.273,1.692&�6s   $	��130��6�   �� 57      -   5        $ 	txtTitulo��57      $
��Left=�6)   $��41��6D   $��
925,93,0,0q�6P   $
 Wrap=�6d   $	��Top=�6y   $	��144��6�   $��24(�6�   �� 58      -   5        $ 
txtArquivo��58      $��0,457,44,60q�6*   ���	#FF9B9B9B$��1q�6W   $��2��6k   $
 Wrap=�6|    �� AcceptsReturn . 6�   �� 59      $ ��CRIAR OU ALTERAR ARQUIVOS ��6   $
��Left=�69   $��450,416,0,0q�6T   $	��Top=�6i   $��28��6�   $	��258��6�   $
��Bold"�6�   $��16(�6�   5:      � 5<   
   -   5        $ GridMenu��5<      $��48��6!   $
��Left=�6,   ��5=      �� 5>       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5?      �  � Color$ 	#FF323232��6#    � Offset$ 0.277Q�65   � 5@      $ 	#FFC50F0F��6#   $ 0.783Q�65   5A      .+�5C      �� .+�5D      � .+�5E      �� -	   5        $ ButtonCloseMenu��5E      $
��Left=�66   $��60��6Q   $��60��6\     ButtonStyle1#���  6�   $y�	Collapsed=�6�   ��6h   Z� ��6~   Z� .��5F        $ 	ArrowLeft=�62   
�������$��25��6V   $��25��6a   5G      �� 5H      -
   5        $ ButtonOpenMenu��5H      $
��Left=�65   $��60��6P   $��60��6[     ButtonStyle2#���  6�   ��6g   Z� ��6}   Z� .��5I        $
 Menu=�63   
�������$��25��6R   $��25��6]   $	��-20q�6i   5J      5K      �� 5M      -   5        $��Disabled=�5M      $	��550��6~   .@�5N      �� -   5         ��Name$ 	cadastrar��5N   #   $��60��66    � Cursor$
 Hand��6B     ListViewItemStyle1#���  6P   .��5O      ��  �� Orientation$ 
Horizontal=�6%   .+�5P        $	 Add=�66   $��25��6A   $��25��6M   $��Center=�6X   
�������6s   �� 5Q      $��Cadastrar time��6(   $��Center=�6>   $��10q�6Y   
�������$��18(�6x   5R      5S      �� 5T      -   5        $ alterar��5T   #   $��60��64   $
 Hand��6@   #���  6N   .��5U      �� $ 
Horizontal=�6%   .+�5V        $ SwapHorizontal=�66   $��25��6L   $��25��6X   $��Center=�6c   
�������6~   �� 5W      $��Alterar Time��6(   $��Center=�6<   $��10q�6W   
�������$��18(�6v   5X      5Y      �� 5Z      -   5        $ excluir��5Z   #   $��60��64   $
 Hand��6@   #���  6N   .��5[      �� $ 
Horizontal=�6%   .+�5\        $ Remove=�66   $��25��6D   $��25��6P   $��Center=�6[   
�������6v   �� 5]      $��Excluir Time��6(   $��Center=�6<   $��10q�6W   
�������$��18(�6v   5^      5_      5`      �� 5a      -   5        $��Disabled=�5a      $	��210��6�   .@�5b      �� -   5        $ salvar��5b   #   $��60��63   $
 Hand��6?   #���  6M   .��5c      �� $ 
Horizontal=�6%   .+�5d        $ DoneOutline=�66   $��25��6I   $��25��6U   $��Center=�6`   
�������6{   �� 5e      $��Salvar arquivo��6(   $��Center=�6>   $��10q�6Y   
�������$��18(�6x   5f      5g      �� 5h      -   5        $ abrir��5h   #   $��60��62   $
 Hand��6>   #���  6L   .��5i      �� $ 
Horizontal=�6%   .+�5j        $ 
Markunread=�66   $��25��6H   $��25��6T   $��Center=�6_   
�������6z   �� 5k      $��Abrir arquivo��6(   $��Center=�6=   $��10q�6X   
�������$��18(�6w   5l      5m      5n      5o      5p      5q      5r      
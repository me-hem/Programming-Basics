<?php

	echo "String Creation";
	
	$str = "Hello String";
	echo "<br><br>Double Quote String => $str";
	
	$str = 'Hello String';
	echo "<br><br>Single Quote String => $str";
	
	$str =<<<Demo
	Hello String
	Demo;
	echo "<br><br>Here Doc String => $str";
	
	$str =<<<'Demo'
	Hello String
	Demo;
	echo "<br><br>New Doc String => $str";
	
?>
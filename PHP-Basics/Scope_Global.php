<?php

	echo "Global Scope";
	$var = 10;
	
	function myTest()
	{
		global $var; //Accessing Global Variable inside the function using global keyword
		echo "<br>Value of var inside function: $var";
	}
	
	myTest();
	echo "<br>Value of var Outside function: $var";
?>
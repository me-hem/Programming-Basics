<?php

	echo "Local Scope";
	
	function myTest()
	{
		$var = 10; 
		echo "<br>Value of var inside function: $var";
	}
	
	myTest();
	echo "<br>Value of var Outside function: $var";
?>
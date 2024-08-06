<?php

	echo "Static Variables";
	
	function myTest()
	{
		static $var = 10; 
		echo "<br>Value of var inside function: $var";
		$var++;
	}
	
	myTest();
	myTest();
	myTest();
	myTest();
?>
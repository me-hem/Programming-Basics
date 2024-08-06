<?php

	echo "Reference Passing";
	
	function change(&$val)
	{
		$val*=2;
	}
	
	$val = 5;
	echo "<br> Before calling function Val: $val";
	change($val);
	echo "<br> After calling function Val: $val";	
?>
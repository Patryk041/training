<?php
class functionality
{
	function SortTable($table)
	{
		$len=Dziusio_strlen($table);
		$temp=0;
		
		for($i=0;$i<$len;$i++)
		{
			for($j=$i;$j<$len;$j++)
			{
			
			if((int)$table[$j]<(int)$table[$i])
			{
				$temp=$table[$i];
				$table[$i]=$table[$j];
				$table[$j]=$temp;
					
			}
	
			}
		}
		
	}
}
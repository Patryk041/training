<?php
	require 'functions.php';	

	if (!isset($_POST['code_to_translate'])) { 
		?> 
		<form action="#" method="POST"> 
			<ul> 
				<li> <textarea name="code_to_translate"></textarea>
				<li> <input type="submit"> </li>
			</ul>
		</form>
		<?php } else { 
			$codeOperator = new codeOperator;
			echo $codeOperator -> splitCode($_POST['code_to_translate']);
		}
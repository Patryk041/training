<?php

require_once 'interfaces/numbers.php';
require_once 'interfaces/identity.php';

require_once 'classes/Number.php';
require_once 'classes/MyDate.php';
require_once 'classes/Person.abstract.php';

require_once 'classes/Finnish.php';
require_once 'classes/English.php';
require_once 'classes/Polish.php';

require_once 'classes/Manager.php';

$todo = new Manager();
$todo->checkAll(array(
					'311280-888Y',
					'311280-8890',
					'14444455564',
					'BC123456C',
					'12345678910',
					'39042207294',
					'03320109527',
					'68041906743',
					'94032805148'
	)
);




/*Examples
Finland
311280-888Y Female
311280-8890 Male

Poland
39042207294 Male
14444455564 Female

UK
AB 12 34 56 C 
BC123456C
*/
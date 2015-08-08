<?php
// xsrf

//session cookie

// perla -> localhost, zal, przeg cookie sesyjne ADMIN

//$salt = 'hewuoghwdpfweighweipghrgweighwerigri';
              // dhsafgad sghdafgdhif/
//	$token = md5( $_COOKIE['PHPSESSID'] . $salt); // rozne

// E&A

// bartek -> alamakota  localhost/zapytania.php facebook.com, formularz $_POST method post name ? input ? x.php zapytanie.php POST name = user id privileges = 128 USER token = $token  
//   zapytanie.php if ($_SESSION['uzy_prawa'] == xyz) {  }   if (post [tok] === md5($_COOKIE['PHPSESSID'] . $salt))
	//echo '55';



if (isset($_POST['zatwierdz']))
{

	require_once 'D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Eagles\includePathSetter.php';
	
	require_once 'TrainingFive/Database/DbHandle.php';
	
require_once 'TrainingFive/Database/DbUpdate.php';

$dbUpdate = new DbUpdate();

$dbHandle = new DbHandle();

$dbHandle->Connect();

$update = $dbUpdate->RenderQuery('applicationtests',


array('codesnipet' => $_POST['yourcode'], 'rightanswers' => pg_escape_string($dbHandle->connectionHandle, $_POST['youranswer'])));



$dbHandle->SetData($update);

}
?>

<form method="post" action="/">
	
	<input type="text" name="yourcode" placeholder="type your code" />
	
	<input type="text" name="youranswer" placeholder="type your answer" />

	<input type="submit" name="zatwierdz" />
</form>

<?php 
die();
?>


<!-- 
<script>

	document.addEventListener('DOMContentLoaded', function () {
			document.getElementById('apply-form').submit();

			window.location.href = '';
		});
</script>

<form action="http://localhost/server/apply.php" name="apply-form" id="apply-form" method="post">

						<div id="applicant-name-group" class="form-group">
							<div class="input-group">
								<input type="text"  placeholder="Imiê" id="applicantName" name="applicantName" class="form-control">
								<div class="input-group-addon">
									<i class="fa fa-user"></i>
								</div>
							</div>
						</div>
						<div id="applicant-surname-group" class="form-group">
							<div class="input-group">
								<input type="text"  placeholder="Nazwisko" id="applicantSurname" name="applicantSurname" class="form-control">
								<div class="input-group-addon">
									<i class="fa fa-user"></i>
								</div>
							</div>
						</div>
						<div id="applicant-email-group" class="form-group">
							<div class="input-group">
								<input type="email" placeholder="Email" id="applicantEmail" name="applicantEmail"  data-other-field-id="applicantFullName" data-validate-other-field-if="CustomEmailPrompterForApllyForm" class="form-control">
								<div class="input-group-addon"><i class="fa fa-envelope"></i></div>
							</div>
						</div>
						<div id="applicant-phone-group" class="form-group">
							<div class="input-group">
								<input type="text"  title="Format +XX-XXXXXXXXX" placeholder="Telefon" id="applicantPhone" name="applicantPhone" class="form-control">
								<div class="input-group-addon"><i class="fa fa-phone"></i></div>
							</div>
						</div>
						<br>
						<button class="btn btn-primary center-block" type="submit">Zg³oœ siê</button>
					</form>
					
					
					 -->
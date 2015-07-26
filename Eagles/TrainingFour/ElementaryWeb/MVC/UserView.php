<?php

	class UserView extends MvcView
	{
		protected function GenerateOutput(MvcModel $model)
		{
			$html = '<input value="'.$model->Nazwa.'"/>';
		}
	}
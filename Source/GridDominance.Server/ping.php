<?php

require 'internals/backend.php';


function run() {
	global $pdo;

	$userid            = getParamUIntOrError('userid');
	$password          = getParamSHAOrError('password');
	$appversion        = getParamStrOrError('app_version');
	$devicename        = getParamStrOrError('device_name');
	$deviceversion     = getParamStrOrError('device_version');
	$unlocked_worlds   = getParamStrOrError('unlocked_worlds');
	$device_resolution = getParamStrOrError('device_resolution');

	$signature     = getParamStrOrError('msgk');

	check_commit_signature($signature, [$userid, $password, $appversion, $devicename, $deviceversion, $unlocked_worlds, $device_resolution]);

	//----------

	$user = GDUser::QueryOrFail($pdo, $password, $userid);

	//----------

	$user->UpdateMeta($appversion, $devicename, $deviceversion, $unlocked_worlds, $device_resolution);

	//----------

	logDebug("user $userid send ping (v: $appversion)");
	outputResultSuccess(['user' => $user]);
}



try {
	init("ping");
	run();
} catch (Exception $e) {
	outputErrorException(Errors::INTERNAL_EXCEPTION, 'InternalError', $e, LOGLEVEL::ERROR);
}
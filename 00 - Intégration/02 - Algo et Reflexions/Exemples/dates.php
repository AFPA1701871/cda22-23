<?php

$d1 = new DateTime("2022-10-24");
$d2 = new DateTime("2020-10-26");
$d3 = date_diff( $d1 , $d2);
echo $d3->format("%a")."\n";
var_dump($d3);

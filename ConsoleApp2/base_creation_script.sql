
DROP TABLE IF EXISTS `car_owner`;
CREATE TABLE `car_owner` (
  `owner_name` varchar(45) DEFAULT NULL,
  `owner_adress` varchar(45) DEFAULT NULL,
  `owner_sex` varchar(45) DEFAULT NULL,
  `owner_birth_year` int DEFAULT NULL,
  `owner_license` int NOT NULL,
  `car_reg_number` int DEFAULT NULL,
  PRIMARY KEY (`owner_license`),
  UNIQUE KEY `owner_license_UNIQUE` (`owner_license`),
  UNIQUE KEY `car_reg_number_UNIQUE` (`car_reg_number`)
);

DROP TABLE IF EXISTS `cars`;
CREATE TABLE `cars` (
  `car_reg_number` int NOT NULL,
  `car_engine_id` int DEFAULT NULL,
  `car_color` varchar(45) DEFAULT NULL,
  `car_model` varchar(45) DEFAULT NULL,
  `car_tech_pass_number` int DEFAULT NULL,
  PRIMARY KEY (`car_reg_number`),
  UNIQUE KEY `car_reg_number_UNIQUE` (`car_reg_number`),
  UNIQUE KEY `car_engine_id_UNIQUE` (`car_engine_id`),
  UNIQUE KEY `car_tech_pass_number_UNIQUE` (`car_tech_pass_number`)
);

DROP TABLE IF EXISTS `inspections`;
CREATE TABLE `inspections` (
  `inspection_id` int NOT NULL AUTO_INCREMENT,
  `inspector` varchar(45) DEFAULT NULL,
  `date` DATE DEFAULT NULL,
  `inspection_result` varchar(45) DEFAULT NULL,
  `car_reg_number` int DEFAULT NULL,
  PRIMARY KEY (`inspection_id`),
  UNIQUE KEY `inspection_id_UNIQUE` (`inspection_id`)
);

DROP TABLE IF EXISTS `workers`;
CREATE TABLE `workers` (
  `worker_name` varchar(45) NOT NULL,
  `worker_rank` varchar(45) DEFAULT NULL,
  `worker_position` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`worker_name`)
);

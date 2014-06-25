-- phpMyAdmin SQL Dump
-- version 4.1.6
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 25, 2014 at 09:37 AM
-- Server version: 5.6.16
-- PHP Version: 5.5.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `holistic`
--
CREATE DATABASE IF NOT EXISTS `holistic` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `holistic`;

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `delete_appointment`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_appointment`(IN `app_id` INT(11))
    MODIFIES SQL DATA
DELETE
FROM appointment
WHERE appointment_id = app_id$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
CREATE TABLE IF NOT EXISTS `appointment` (
  `appointment_id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_id` int(11) NOT NULL,
  `time` datetime NOT NULL,
  `practitioner_id` int(11) NOT NULL,
  PRIMARY KEY (`appointment_id`),
  KEY `patient_id` (`patient_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=29 ;

--
-- Dumping data for table `appointment`
--

INSERT INTO `appointment` (`appointment_id`, `patient_id`, `time`, `practitioner_id`) VALUES
(22, 1, '2014-06-25 09:00:00', 1),
(21, 1, '2014-06-26 11:00:00', 3),
(28, -1, '2014-06-28 12:00:00', 2),
(19, 1, '2014-06-24 10:00:00', 3),
(18, 1, '2014-06-24 12:30:00', 2),
(17, 1, '2014-06-24 09:00:00', 1),
(27, 1, '2014-06-29 11:00:00', 2);

-- --------------------------------------------------------

--
-- Table structure for table `availability`
--

DROP TABLE IF EXISTS `availability`;
CREATE TABLE IF NOT EXISTS `availability` (
  `availability_id` int(11) NOT NULL AUTO_INCREMENT,
  `staff_id` int(11) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`availability_id`),
  KEY `staff_id` (`staff_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=239 ;

--
-- Dumping data for table `availability`
--

INSERT INTO `availability` (`availability_id`, `staff_id`, `start_time`, `end_time`, `date`) VALUES
(237, 369250993, '01:00:00', '14:00:00', '2014-06-25'),
(238, 369250995, '08:00:00', '15:00:00', '2014-06-10');

-- --------------------------------------------------------

--
-- Table structure for table `cancellation`
--

DROP TABLE IF EXISTS `cancellation`;
CREATE TABLE IF NOT EXISTS `cancellation` (
  `cancellation_id` int(11) NOT NULL,
  `appointment_id` int(11) NOT NULL,
  `invoice_id` int(11) DEFAULT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`cancellation_id`),
  KEY `appointment_id` (`appointment_id`,`invoice_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `consultation`
--

DROP TABLE IF EXISTS `consultation`;
CREATE TABLE IF NOT EXISTS `consultation` (
  `consultation_id` int(11) NOT NULL AUTO_INCREMENT,
  `appointment_id` int(11) NOT NULL,
  `medicare_invoice_id` int(11) NOT NULL,
  `copay_invoice_id` int(11) DEFAULT NULL,
  `practitioner_id` int(11) NOT NULL,
  `startTime` datetime NOT NULL,
  `endTime` datetime NOT NULL,
  `reason` text COLLATE utf8_unicode_ci,
  `symptoms` text COLLATE utf8_unicode_ci,
  `advice` text COLLATE utf8_unicode_ci,
  `notes` text COLLATE utf8_unicode_ci,
  `prescriptions` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`consultation_id`),
  KEY `appointment_id` (`appointment_id`,`medicare_invoice_id`,`practitioner_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=8 ;

--
-- Dumping data for table `consultation`
--

INSERT INTO `consultation` (`consultation_id`, `appointment_id`, `medicare_invoice_id`, `copay_invoice_id`, `practitioner_id`, `startTime`, `endTime`, `reason`, `symptoms`, `advice`, `notes`, `prescriptions`) VALUES
(7, 18, 78, 79, 1, '2014-06-25 16:46:06', '2014-06-25 16:47:22', 'Too much hair', 'So hairy', 'Seriously, just cut it please.', 'Whoa.', 'Scissors');

-- --------------------------------------------------------

--
-- Table structure for table `equipment`
--

DROP TABLE IF EXISTS `equipment`;
CREATE TABLE IF NOT EXISTS `equipment` (
  `equipment_id` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(12) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `description` text COLLATE utf8_unicode_ci NOT NULL,
  `price` decimal(8,0) NOT NULL,
  `max_hire_duration` int(11) NOT NULL,
  PRIMARY KEY (`equipment_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=5 ;

--
-- Dumping data for table `equipment`
--

INSERT INTO `equipment` (`equipment_id`, `type`, `name`, `description`, `price`, `max_hire_duration`) VALUES
(1, 'Mobility', 'Wheel Chair', 'A wheel chair to moved patients.', '5', 14),
(2, 'Mobility', 'Walker', 'An A frame walking chair to aid movement/walking.', '6', 10),
(3, 'Mobility', 'Mobility Scooter', 'A scooter used to travel from A to B.', '24', 20),
(4, 'Therapeutic', 'Message Chair', 'A reclining message chair.', '18', 13);

-- --------------------------------------------------------

--
-- Table structure for table `fingerprint`
--

DROP TABLE IF EXISTS `fingerprint`;
CREATE TABLE IF NOT EXISTS `fingerprint` (
  `fingerprint_id` int(11) NOT NULL AUTO_INCREMENT,
  `staff_id` int(11) NOT NULL,
  `fingerprint` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `fingerprintFile` blob NOT NULL,
  `modified` date NOT NULL,
  PRIMARY KEY (`fingerprint_id`),
  KEY `staff_id` (`staff_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=6 ;

--
-- Dumping data for table `fingerprint`
--

INSERT INTO `fingerprint` (`fingerprint_id`, `staff_id`, `fingerprint`, `fingerprintFile`, `modified`) VALUES
(1, 1, 'Fingerprint', 0x00f80f01c82ae3735cc0413709ab71b0f6145592b051b3d7340e86358fb90f2c1864c47168b57b520eb42ff2ece010dfe3d9c180cce2008d5204d4d3714465695289e5566ff1a10a19170f5cf7e319197aea1ebf46a4363699271a3e3fc6dc42f377e8f37a18b175ec08d4db8c3d7a603e8578b1e4f54c5a8ddde5b0d4db153536f1598414fe7001429a52acbcd9a9e7229ac4bcc80bb9c635eadf541767559c722dd03fd0b8a55cdd7e18a5972164ce774b35e09ac36ee59fdc245c1a2ba32ccc4480be49b6b679386d0a869e698e6eb9c1935500d3f6c7d7db502ac90d0ed6545567df0dbd3270e870b0f28bc49bd61d229a5d405993de25c43cd5725f4ee2c6cf48747fe9712ff3228c564edd56e78c2b016f00f82401c82ae3735cc0413709ab71b0f3145592ffce2f1b0045b5d3ab5be0575227b039db3ff035cf0c0075494763b9dc6aa49ec314b6169ea71f2050cd0b7326a5e65c295dfa67f11d54246c4c6a024c9c5fbdc0a0069c3c1ceafb20e3490b49e9959fc338e7e5f79a3c4c4b3e68897b51c23bc03b83753b0742fd605844196dddd41b53028693071f0013fed6654cf6f9018abe3c904f8f8f64a282fa05a15bc57bff1e72b250cdaaaf7d466486236473886ed87230ebae91c74a95245f1e1ea02ec20099be32a8886550c12b9825740ce97eacb7565bc65b651d8a1715c4b64aaa49fa329588d40efce5b68d7ebfcf7a847624b92ac3716933f982468fc21bcd00ff54bc2a076773dd9d0bed24b7f8378ca983d3bf39b318c93c1e0e86d51c15720e897771a56f00f81501c82ae3735cc0413709ab71b0f0145592e8d9ebd0ad2111ef08e6fe6f585579bc4e88aaa3701936c48e58b9c6e5a1a6f09bc8bed9c2896b9f97cc896db6cb6e11a99a43e86a61cf9759f295ee4f26edd9a83053124c10d9c7e9af6a75d7b811cf1356c996dfefc2507ea0f1f9938eb77ec18a246f1de087fbc244a0bde53efe7f74a43524f1fe6c099e8d5e02b39bfeb9c4a49602349fb02e526be4221ceb9f34e4a8e28e1d2c1bc4177470b2f9fcccf9f0e282085ca7296582dde84bbb0cb1099368e70b24a4035c5db940ec635f14d7434800492d8aee030d8926ea0859b391f6564773b74ba7264d04e7d4a30caff7b0277ee831993e9651be99976d13aa471e280a09fc7eb85e08d36cf988419c7be5daf0d9cb6f00e82501c82ae3735cc0413709ab7130f7145592b9f4aab7b4ce0e3fae9f83a8908ccc6102ca4e71abdd6da7a88d43356a17db3f03977bfd491434e50a4777abd91c42d918a432cd01b0052283967accf0a6f3cada922a6397c457924e4ee094b975ee5bc87176e7204a0fa5d96eaf150fea4aa716684817fc6ddb8b4d0cfe09e5101042963576cde308b93852f820740c85b5c3afb021dbe675ada833b5df698cb3e17783625fbcba16dffce013e06744385c283c84d246bea5dc65fc725babaf293e74800eaa1d0e615b340a23381613979e779003efe46c43c14a9617cf863cbae7f914c2df230b84b725b7c5ead978aef03dc883f1a69374e26d6adc15d26627c794b1aafe2759a6e00efb69084325b79291c5c25ff9c8fc133346578ec45b8880aa865e383bc66f000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020001000300010000000000000000004cd1ab0274d1ab02000000000000000004000100050001000600010007000100ecd1ab0214d2ab023cd2ab02ccceab0208000100090001000a0001000b00010064d2ab0294cfab027cd3ab02c4d1ab020c0001000d0001000e0001000f000100b4d2ab028cd2ab021ccfab0244cfab0210000100110001001200010013000100dcd2ab0204d3ab022cd3ab02bccfab02140001001500010016000100170001000cd0ab0234d0ab0294d4ab02e4d4ab0218000100190001001a0001001b000100ccd3ab021cd4ab02bcd4ab0274d6ab021c0001001d0001001e0001001f000100f4d3ab020cd5ab02, '2014-06-25'),
(2, 1, 'Fingerprint', 0x00f82501c82ae3735cc0413709ab71708a14559259cead66a7f31462b9a091d3b0fde81da1ba197bb908264607897a97619ddcd5b42cd98413aa9983ea3f1d640383e0631d2c8776e728d26541dde772ac74574361ba51f79ca0a70526a286463df3dddb2bdc91ddf1364f955597511e1761ccf960b7b3dd15480561dbd5ecf1525dfca16ab1125d4a33dfc6757fba18b45d8968521b4db61ff05db3d79e879a5fa336cc5f98ad40cf94d598875a82c01d4c9c5ea72d4caadf81427cfd1d0637e28698aff359ba6576f1643ed7273dcc03cf55c4bcbddd921dc20d82005c89a6bc35eef6ebb51f28f571b8b2e4af797a8aa83c284b91b19caccff1edc8f499d20ddd0f300742e6d3e0f758114eeb797ea819cede2e9ab3b18b7e9ab48787ace1bbf2cbea27975b112b6f00f80001c82ae3735cc0413709ab713088145592ec592612d9e3fd8a009e42259b616e0337af192ca33597d5345bada01275fe2f8e8d3afc99b3ec848c4e534c374a8557a18f61cc7d07dae31f32add0fa22de0d25b89da1e974f22acc088a49a9749ab3c63cb03c94a56c6f8d7126aa02b4aea0128ab441c374391df7f567dc1cf1a02c2ee5b8b02b928c7180a7b44bac2d33126bd8da92ce0fa7f2e4865085baadf1a77fd9b4aa966a3d25aa44c41a4062e84b3bb45c267b99aad80aacad8f52f2f66b8a5562c57dcec98d9c6c0a859c2381307e80d86d3d4c092a12fe26fafd3fbb8974d2f1721ea8c52dd4b2797d34bdbcc28de746a97a7c0cd3fd36dc698e634fd56f00f81801c82ae3735cc0413709ab71b08914559207a254248e908edb4734875f4611ba03240316db0f39c8a8ce1159132be930db25bf448ed1065610405d174d65cd224ae698859ffb369cec6b121353de543e6024a135deda5b967088f5b305771c614e4d3cec9b8d4b7fb5d06a52e4f362ae01d94c33912c28f7eaff73f8783125e327ff2528793ef2ad76ed6133afda05252a3b0172c5a79c0f8003706a0d44ffe26fc986c74a3fd6a12d96c94d704390319a32e72dfcbd7165685fc1304f0dd89c37d8d64c9e69dc04488a18e98fa305d7a568601b4b8aba9522ae13ffce2275dcfc01fd38b52db8aa7f1de2740f9d4cbe15bcad4764b36595ab25140b350b41f7c276bd41d56c8ef7b936ac2645862bfc8ec486da9f10c2925f6f00e8f100c82ae3735cc0413709ab71f0fa145592a8e006e8ddce91620b22890c56d4e19bbb355fded8f56b9e2e20ee45a186307627b8385f8ce30416a54bf42f8b6683207c4342c7a373d10e8c877b9a321cf48273f76fadf624f47413e1696836616417a2642ba68e59f5cb14ac7cdea3cf384e98992b2c48f3340f4d7dfbfbe7c67804bee1d0b70573c70f00801942bd3200060f24deb725a2cd9d0f9987f52d3961752d883bbe1eff9c4769e9e4fc5abfd215890ffff10dff2d26513b48dbb98eb8ecf7134740857ea428522fb17d116b1cfdb274d713b5be34fd7905b291c63cae48dcdfae5f6845e3a7b3e050576882794dd06f000000000000ffffffff21210b0058770000680000005800000003000000000000000000020000000000000000000000000000000000ffffffff000000008c24000000000000ffffffff0000000000000000ffffffff0000000008000000ffffffff0000000000000000ffffffff27210c009c770000680000005800000003000000000000000000020000000000000000000000000000000000ffffffff00000000bc24000000000000ffffffff0000000000000000ffffffff0000000004000000ffffffff0000000000000000ffffffff26210d00e077000000000000ffffffff03000000000000000000000000000000000000000000000000000000ffffffff000000005825000000000000ffffffff0000000000000000ffffffff0000000004000000130013800000000000000000ffffffff26210e00e077000000000000ffffffff03000000000000000000000000000000000000000000000000000000ffffffff000000006c25000000000000ffffffff0000000000000000ffffffff0000000004000000030003800000000000000000ffffffff010000008100008135810c00d0966005d0e4f600010018000400000000000000000000000c0000000000000026210a005877000000000000ffffffff0300000000000000000000000000000000000000000000000c00000000000000000000007824000000000000ffffffff0000000000000000ffffffff000000000000000000000000, '2014-06-25'),
(3, 2, 'Fingerprint', 0x00f80c01c82ae3735cc0413709ab71f0d0145592d759cf73ad82554fe6daf92a29ca74d5dfddfd23a21fac7f4247b41c4d946d7d2a33cd9cb5ad22e30c869edd6c45c16e7b658d355f0270f24f2168c6a61656ad0f8606fefc8df4304208601143e9b7626f35d5e7da1d4b9a8659c5eb33d01d8e6fbd866173b84b0fa93d336c8ecce20825c8e4b4f0ad68292c18850d599fbd21797868ecb59fe8ee392777094441003e67653ffa0903720bbee5fc514c15b7fb6a59241154d9e02cf3d7910a7d16877562be8a9ffc0a2615a5f109507b8aedfc66b0e6374665fff2894219599f046039bed9553919cee3fc1088d9ae2506b2c3475d9cda5bcc471d6b0e10d2010f5483c2a7fc49ddf89f11217954e36f00f81401c82ae3735cc0413709ab71b0fa1455921c956356ace3f6ade17575f8d978899a7ce7ce1397dcf1c0f675bb6aab10051521e217aa00ffef51a29cf60122bef7781031b2520d6f33cc4ff611aa2d50493f560c2b1abf39355192d81bd5e64a47c1bb2874053c4e60c29c2353b0e5e6e58cf0ce7ce77d571e4b67d75ed8a60ed0e8c7b22b594c3eab136f65a61ce6d8bca3cb4dba1ffc5bed1f4b57eb4ab819c78488d39aeba1b399b87c744f5ad1fbf3529f487722b68de276b606a3af8428ac9ba2cf1e281811ffef09085979770ceb53b5b1e99d0899684d5564a494ad1cc5d6a6277ce428d0b68c16dd10232c0c9c7cfd96957fedbf0221b248a52e9246bccaa28b6e483653b411ac8bb36ad25553fbb660eb4e6f00f81a01c82ae3735cc0413709ab71b0e114559262f161cdf779f57d029bb81642087bdfb9d03fb8335a93ec4240b19e8aeb48b37cdcbe307b42b8eb34e30b15f607310542278d5d4556c6dfe1cc019e8b13d8ed1051ba7a1d64622be90665e5a80fea4e8380907bdb3c9878c4da0e4f10c2b125192fb9cc4ff034f24af522a5600db6865777c1275def1f32f5e0a4b6351fbc484b5d3fa5e303ffb3db0fd0b1c2f471eb88378fe0e2bc13de007a572cc6bc990b0be2f380b15ac048cb48c22f74afd5202b6354b3754dd08629663613f62b714c6bfbf479b36f7fe8003222619e09faad345fc4c2f8f862a3e67b19cc45f636f18500a93f5a90ccf7738c164f8c20b588327e24690f79d11ddde876b9ed4acd314b85b6c2a06931d71da86f00e80301c82ae3735cc0413709ab71b0d7145592d8e383d5783ead43be0149574e95cec4f8b9d5cbd4cfcab39c4ec7bab451698542c9dc6c4474aa3ee0294c8056db0151883fcc69bce5a2cd5dc3c28f908ec7eaca1bd5703a9234f3965850d77ef759cdaa92487fde5d4abd31c4f36fec8ce0e6102918ff692d405541ef2165d03617fdb52affc8c21596c0141904c1a4aad71de3d6bd27c8810d383197174ad9a74373a1f7b79c49cd670d932c22f1148fc44343bc12de2064e1587011425344afa4f469acc1918f64fff3c3c2fe8d6f91e76b9422073b732350c98750347321a57c18f3d73628175166349a9e8527a2e150a75605d48cc3f412e9cb007dbf097b7a522f69866f770000680000005800000003000000000000000000020000000000000000000000000000000000ffffffff000000008c24000000000000ffffffff0000000000000000ffffffff0000000008000000ffffffff0000000000000000ffffffff27210c009c770000680000005800000003000000000000000000020000000000000000000000000000000000ffffffff00000000bc24000000000000ffffffff0000000000000000ffffffff0000000004000000ffffffff0000000000000000ffffffff26210d00e077000000000000ffffffff03000000000000000000000000000000000000000000000000000000ffffffff000000005825000000000000ffffffff0000000000000000ffffffff0000000004000000130013800000000000000000ffffffff26210e00e077000000000000ffffffff03000000000000000000000000000000000000000000000000000000ffffffff000000006c25000000000000ffffffff0000000000000000ffffffff0000000004000000030003800000000000000000ffffffff30710d6e11000011fe6e0900a8497805a8e57b05e0cf5e0b609f1f0154710d6e60710d6e60710d6eb00100000c00000c816e0900d8681e0138ed1f015b040000b60100001000000061040000bb0100000200000062040000fdffffff0200000005000000050000058a6e0900d82686053861570b08d40000bc10681788d62792330e9c37, '2014-06-25'),
(4, 3, 'Fingerprint', 0x00f87f01c82ae3735cc0413709ab71f092145592f9be455e2051e2cbae07a7ecabf86fc9158ab2dc5df01e5cd3ac801ca9d0bb83f3cfa1178443b1f9b5d82069730d2cf9849eacc4f074c586cd4a5afd3fb7498b58794c3cb0ef0905fa13f38458f46bdc45673439c74293d576ab0e8c27eb93196a9bbee81803b9d09ef96542915e7fbbfd7e9c8dad0de690e285624edafa59869dc7f320e8f0228bed8b86eee8b9e34730d317e5b5d19b7c2bd84af7cd8d27332d51550ad83cfb21d714eeea2a5c2b4147ee14d3f92a134e8e55853cbbd3967cc7ab530a6fdc6ee452cf7567aaf61bef7fb584c62c059445ecf125d1fa59f53287c7dbdd374ad106979e21efd383b634af4798154620bd49185b67030ebe46e4e4b350658250a6646e81ab474add67ea62d3c27223040f44628fa3cccc219f57fef77b66e4df60c339a07373f2802aa3a284bf1ae7193ca21af2a658ef4f327abf1936336ca0e6d0c912e14b6e66f5b72e7a5f1895964f69a7acca46c22c877567c5da9fc6a3b6e9631d154f0397e16f00f87c01c82ae3735cc0413709ab71309a145592a457fcade514c6f025a10d6e339afc841d98cac19220184b98d5091e50d77144e911297bb853d75e8b975dde18a5bf722ab6d33ec816379c315f26a924899f0dae42ce0599f41f8af5e6d65921a6cb5804c62e17da43e6a3018f5cdd23927f43285b612bc42e4949faa3fb3ecbd244534e63edc2d2a07cb80639e6ff7ed0020f0ac8c84cfa584d5062a58d21507608bafa6e9467a514d8e88e8a8f7359c9e3c2b50273d795b8f8cd6f88d5a3eb4f6e05e861fa1999d822a3562c63fa623e0c40b45978fecaaee7ceb70d9a7fd714ddd5f516d05420cf489e2f722407d266a529f3698216b0acb4d0cd305be15c150ea1c6f6d03b0c7408eaf34142bf95148aca1205158a847bc8924b0cce52fedb3c8a642e37966245cf3b3c49f33fc4a11dc92d5b0a7905c9a9ea8d867d2861cd5b2992bcff6af2f8ae5283107018796a18a021222eb57de3c419ce7ff0984657ce7e97f60e1b528c753c6d89f8a65d3d0dd5f4df9cd6dfdb2d7093993b5e6f00f88101c82ae3735cc0413709ab71309c14559205e500e573866c7d6949c21ad982bb0375953e9f5d17ca2541b7387d7fccc9a2f26ab117fcc61f58e6311732e06287fc60c61fac4456a49cd851deef0668308b76e069413bac191e6fc832af8329e3174774951d5e2e0e2043f53da3f880d43cf07b7834595a6262ee85d21d189e1e4dd57afdfaf3781b3cd4d1b84f1bb1d691a7407b622bff6d82e956f00fa8d14e50ffabad3f8c86527a5eb999f8e9ff4d59c3b04e2bcf0fafde5a95329a61110c5874980c5c6d938508f82be23edb28e089b556bf99d3a93c6f58e9089b4c9fc6a33f8191d272f63c6d132600c142f4396d56e8342f0bb74906cdc249c37d5ad69a9c861315cb06abe72b80038a91a07e9bd6a6ed48d4c5a18ec9a83a9df650818ead4cadcb88d3d35a735cffe91ea89478f07b24fdf0c0a932879f1cac75ff76e0b9a3da3ca32e9ba687011efb0b73af9c20be355d5fc11489c22a29f5873fa19ace82eb9287ef5d18213eeb027ad70ce8277b8e04c89fda2a7910f7de571476456d6f00e88001c82ae3735cc0413709ab717085145592b7252e5ea00e7823b05f17a50b248ad192a0c71dc0d94a4c8dc3fffb97dcbe5036c9d97474e2391bf9843b5369e50525a4627f8893b6e217660d8703c4f4ef8b338a1b8ff8570e9c07f37f65a8aa131c51d3cc252b5f2ab9de1ca5b4f5b299ec203fa85630245a25837deebf98e76581788479b85a5d5d67e6b0951cbea88c7e8c18ffb3527f243f713bcf5c8687f617627a3dc0cb18c917251ab1c8777f05c04313eb6953a55eb50d386a51f25491ee682fce7fdd01cd31f27320ce1f7d76e5865cca4cefc5036f77d1f6055324fd20709c5e2ee6d9ef7080ee2021eeb8d405c6bd83bbaeb07f44471fb4f77a106073d9b116de069ee69bc12bea8afadf822de4fd93abb271d51f2eee3d63753346012027177970ba777bc83f3f9b9b69b7ff0ca8927bf31b3d795b93328a1c03f0723ecbbb8601ce38937182b77ccea860a82aa0ab151914fabdcfba0d6c6bac03e2719f3ff7fba4d5f802d8d507d980617dcbfa93bdafaa8d234a07b78ca92430d86fb5010000020000005b040000b60100001000000061040000bb0100000200000062040000fdffffff020000002086856b0400000479b41c0068e3a1050856ba004086856b4c86856b4c86856b1473796b, '2014-06-25'),
(5, 1, 'Fingerprint', 0x00f85e01c82ae3735cc0413709ab71f089145592bf179c83e56d61a867bc62f252b0228eace2b98b76b220d6673745d751afcac9dbe1ffdaf052d944c1795c5f15289cefd6fbf2fb2c510b463d24d90fec02df67bf2fc011f1ee00bd49f76745af9e916ff6932bad0fd4f8d8eb4469509e4c5ac4a938eda85c42e31c317bbd78312a0e28ac204c4b473bb9254931737d315c71eeec17de32fc5383865688120296e66f7c6163832195b3c170347f5af43ff422437e8939658d151fdf18f17c9840654918bba3612c4f194b60fd443bab7922b36e2cf5c88a1614b745e0a5bbaaa58a73c9969ffaea80219453c18a1443e50efdcfc3b16bd4803d467b42c724bc079b081d8466c88f9bc86616f73fda6130f3468ac5b61972ef20443c37f26dbc35993cd54abc13c23be118184237bfaa57658f38597af3c3beab8d7075817c2f8d336ff1306997d96c0a57f2196ece80ce856b7017b2ab42f44585f82e94646bb61b6f00f85c01c82ae3735cc0413709ab71b0fe1455928b1996c81e169d6c50e05be5dde84ec24f7a2eba629bd55d261d66988dd603faced77d71ac9efe68bf7fed5e53282978f9131f45dd27a3a36425f94e4f26e2a8fa454fd44c82a79a4b894df2a32ba51dc2d26b5e054094d90928447ed3a487ad8f0121fd248a56214cc365b86bac8384cde8fc7c72229d00e2f84e45342c5e6409f81cf5d3ea623e2cffc5629ff93740f77d23fadf186a2594f8cfc097ba319041e55cbe79250bca8df8f7700475bd0e8a42782549ed16cfa3fcf176a93b3d0faca2eb46230c46b619bfcb733a719497653805e1d59111d73a705016b7b37853532d8932f17081c29aa97cb689b3bb6e3335bd3a865793a8de86bd75092ffe021e03dbc69a4043dce43f7b32797b93383596c14997cd43792026f317012ba240137856c252387f35bab1aecf7ceedcaff3b0b4d230b3100057cb02ce69f5c1c723764b9706774854c1b0a18e6f00f87701c82ae3735cc0413709ab71f082145592e3ac9bcf7b79c24ba05f5f32ebcae414f74903337a49bffd1acfdfaf83eebe7f0bb41584634d21dd74c1b2ea177cf4800b7132ceae8c2ae1cc58c66f7d8e3601ed3f24fc51da5fe5fb79953ff3bd464b6e346c562a60886c4638092eaf6259544cc3e2b9bf66b733f146fa49e6b70e872621b54e3c9454abe8d9c7f79d3230c056b77610d6411ebb83b9598dc408c8de4f8c54bdc21cf1c83c43601f7bda4d85a9f581233e1a8575890bc6cf48994df8a28015263043f49f70038801b04ba8047bd28f75f977807b64d23ff36c7022e2adfaf12a2b241dd837515df51a9cd17969604bfa862ed3cab9e856cc9b7643f648c10bf010fa9f504591fdd5b836396a2c4965672cb47e5616c1c46800fd089858f166ccb36d3f7b209e59455d9489778901be5774f47a7da8411b49c222c2566c260e0379eec347704291d15936c99a54ef7f46fa8c4c7cf4af8a85855a515906a77d158436cd5543d9a509dec6a622dbd3e9570b96866f00e87a01c82ae3735cc0413709ab7130f6145592307fab6b7632c5de60c0c08b618cceb85c2eae4ac9a2bf6f128cdd7be93802762f046f68ce0863ecf1d0af10b507a83fc9c75403b5f4415c03b12ee6e3cedde6b17cebb7c46d65f444fc32c2da69bc3913749b92280d1a7ba173fc26451d75494f779804ad5519b75be6002943092188e53012f0dc09759215f85dbf1f6b76b652ab9a47bfa707f04d71f6118abdd05fbc727914090b7e8c0901e6a71167bf35b650175dd6f0587d97e7a1c83b896b4f976eb24856a420dbbd76bb97e985184f7a3d34d750a6fcd058521553ddda7c49525a3bb10cc0b3216be153a4162858b07d09548d6654c9c1c176c8107993ae90ae249b7afc26999605fbe287a0fa0fe2c25c276d1aa8959b895b7f4baaf358b834d8ee0b209ff64ca6265fb40038170292afc1f2198ee090c1ee358032126bcc51c789dd31deee9a7231f8f5688abecf38482caecca38201d8ae5f00b25f2c3068adddd591f12abff5df697e6025616658e5dbaec7ef6a3114956f00020000002a040000a30100001200000032040000a80100000000000033040000a9010000020000003a040000ab0100001000000046040000b0010000000000004f040000b00100001000000055040000b5010000020000005b040000b60100001000000061040000bb0100000200000062040000fdffffff02000000fa0400000d00000de8fa0400f0f3cf09d00b340102000000000500009a01000002000000, '2014-06-25');

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
CREATE TABLE IF NOT EXISTS `invoice` (
  `invoice_id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_id` int(11) NOT NULL,
  `total_amount` decimal(10,2) NOT NULL,
  `status` varchar(8) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`invoice_id`),
  KEY `patient_id` (`patient_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=81 ;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`invoice_id`, `patient_id`, `total_amount`, `status`) VALUES
(69, 0, '55.00', 'returned'),
(70, 0, '62.00', 'onhire'),
(71, 0, '23.00', 'onhire'),
(2, 1, '200.00', 'UNPAID'),
(3, 1, '350.00', 'PARTIAL'),
(74, 1, '150.00', 'PAID'),
(75, 2, '400.00', 'paid'),
(76, 812312, '350.00', 'aaa'),
(77, 812312, '211.00', '2131'),
(78, 1, '220.00', 'medicare'),
(79, 1, '10.00', 'paid'),
(80, 1, '10.00', 'unpaid');

-- --------------------------------------------------------

--
-- Table structure for table `lease`
--

DROP TABLE IF EXISTS `lease`;
CREATE TABLE IF NOT EXISTS `lease` (
  `equipment_id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `invoice_id` int(11) NOT NULL,
  `hireDate` date NOT NULL,
  `daysHired` int(11) NOT NULL,
  `expectedReturnDate` date NOT NULL,
  `actualReturn` date NOT NULL,
  PRIMARY KEY (`equipment_id`),
  KEY `patient_id` (`patient_id`,`invoice_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
CREATE TABLE IF NOT EXISTS `patient` (
  `patient_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `first_name` text COLLATE utf8_unicode_ci NOT NULL,
  `last_name` text COLLATE utf8_unicode_ci NOT NULL,
  `gender` varchar(6) COLLATE utf8_unicode_ci NOT NULL,
  `address` text COLLATE utf8_unicode_ci NOT NULL,
  `phone` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`patient_id`),
  KEY `user_id` (`user_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=101 ;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`patient_id`, `user_id`, `first_name`, `last_name`, `gender`, `address`, `phone`, `email`) VALUES
(1, 1, 'Juan', 'Nguyen', 'Female', '66 Monument Court', '5-(041)703-0', 'jnguyen@dabjam.net'),
(2, 2, 'Lori', 'Garcia', 'Female', '5881 Northridge Drive', '4-(827)097-8', 'lgarcia@fivechat.info'),
(3, 3, 'Brandon', 'Wells', 'Male', '928 Summer Ridge Alley', '1-(934)334-5', 'bwells@skimia.name'),
(4, 4, 'Diane', 'Ramos', 'Male', '8 Pond Terrace', '6-(040)419-9', 'dramos@demizz.info'),
(5, 5, 'Lawrence', 'Dixon', 'Male', '17799 Morningstar Park', '3-(047)229-9', 'ldixon@tekfly.gov'),
(6, 6, 'Aaron', 'Stanley', 'Male', '6978 Nobel Avenue', '2-(295)270-4', 'astanley@meezzy.com'),
(7, 7, 'Kathy', 'White', 'Female', '804 Muir Way', '0-(900)960-1', 'kwhite@gigazoom.com'),
(8, 8, 'Terry', 'Stanley', 'Female', '7 Debra Hill', '1-(250)538-3', 'tstanley@aibox.com'),
(9, 9, 'Rose', 'Gonzalez', 'Female', '03843 Calypso Place', '3-(551)375-8', 'rgonzalez@voonder.edu'),
(10, 10, 'Bruce', 'Ramirez', 'Male', '02265 Milwaukee Hill', '9-(192)244-6', 'bramirez@fatz.name'),
(11, 11, 'Billy', 'Oliver', 'Female', '533 Melvin Crossing', '0-(925)925-7', 'boliver@blogpad.net'),
(12, 12, 'Margaret', 'Ryan', 'Male', '82 Florence Court', '6-(204)590-6', 'mryan@vipe.info'),
(13, 13, 'Brandon', 'Robertson', 'Female', '02004 Corben Parkway', '5-(488)924-0', 'brobertson@mybuzz.com'),
(14, 14, 'Henry', 'Rogers', 'Female', '3728 Warbler Trail', '9-(398)549-7', 'hrogers@voolith.net'),
(15, 15, 'Stephen', 'Martinez', 'Female', '339 Rutledge Park', '8-(553)971-3', 'smartinez@katz.mil'),
(16, 16, 'Sarah', 'Hernandez', 'Female', '2 Ilene Avenue', '2-(836)731-5', 'shernandez@livetube.info'),
(17, 17, 'Betty', 'White', 'Female', '9 Bartelt Junction', '1-(359)666-3', 'bwhite@yata.gov'),
(18, 18, 'Peter', 'Reed', 'Male', '66 Fairview Park', '5-(029)852-5', 'preed@yodel.mil'),
(19, 19, 'Harold', 'Murray', 'Female', '7 Utah Terrace', '5-(314)464-2', 'hmurray@skinte.mil'),
(20, 20, 'Sara', 'Smith', 'Male', '8 Roth Lane', '0-(624)722-2', 'ssmith@twitterwire.edu'),
(21, 21, 'Rebecca', 'Franklin', 'Female', '515 Cambridge Court', '8-(525)399-0', 'rfranklin@myworks.com'),
(22, 22, 'Brian', 'Medina', 'Female', '72767 Sunnyside Road', '6-(503)035-1', 'bmedina@chatterpoint.com'),
(23, 23, 'Christine', 'Meyer', 'Male', '05616 Northwestern Lane', '2-(575)289-2', 'cmeyer@photojam.org'),
(24, 24, 'Ernest', 'Patterson', 'Female', '7 Prentice Point', '4-(418)161-5', 'epatterson@quaxo.mil'),
(25, 25, 'Elizabeth', 'Watkins', 'Female', '16063 Autumn Leaf Park', '9-(243)420-7', 'ewatkins@shuffletag.info'),
(26, 26, 'Carl', 'Henry', 'Male', '42804 Forest Circle', '2-(981)708-9', 'chenry@wordpedia.com'),
(27, 27, 'Carolyn', 'Lane', 'Female', '513 Hermina Point', '0-(571)197-4', 'clane@riffpedia.gov'),
(28, 28, 'Cynthia', 'Morales', 'Male', '603 Goodland Drive', '9-(671)529-3', 'cmorales@wordify.net'),
(29, 29, 'Michael', 'Ramirez', 'Female', '32 Loomis Junction', '4-(976)627-9', 'mramirez@quimm.edu'),
(30, 30, 'Doris', 'Ray', 'Male', '980 Waywood Way', '7-(159)443-0', 'dray@zoomcast.org'),
(31, 31, 'Jimmy', 'Long', 'Female', '100 Mayer Junction', '0-(184)306-9', 'jlong@oba.edu'),
(32, 32, 'Nicholas', 'Hayes', 'Female', '39 Shoshone Avenue', '7-(338)447-6', 'nhayes@topdrive.org'),
(33, 33, 'Diane', 'Sanders', 'Female', '460 Eagle Crest Road', '3-(591)361-4', 'dsanders@oodoo.mil'),
(34, 34, 'Elizabeth', 'Wood', 'Male', '5982 Express Hill', '9-(481)641-8', 'ewood@youspan.info'),
(35, 35, 'Roger', 'Banks', 'Female', '56379 Arkansas Crossing', '6-(256)836-9', 'rbanks@wordware.info'),
(36, 36, 'Nicholas', 'Gonzales', 'Male', '5290 Chinook Road', '3-(580)588-9', 'ngonzales@skilith.mil'),
(37, 37, 'Lois', 'White', 'Male', '21706 Crest Line Road', '5-(069)892-6', 'lwhite@skipstorm.gov'),
(38, 38, 'Janice', 'Price', 'Female', '5352 Golf Lane', '5-(199)209-3', 'jprice@livez.org'),
(39, 39, 'Jerry', 'Wagner', 'Female', '8 Michigan Circle', '2-(236)511-8', 'jwagner@roomm.net'),
(40, 40, 'Jesse', 'Price', 'Female', '58 Fulton Junction', '6-(468)239-8', 'jprice@eamia.mil'),
(41, 41, 'Christine', 'Brown', 'Female', '7001 Gerald Circle', '3-(181)209-8', 'cbrown@jaxnation.info'),
(42, 42, 'Lois', 'Marshall', 'Male', '63646 Westerfield Point', '2-(862)609-1', 'lmarshall@skalith.biz'),
(43, 43, 'Jeffrey', 'Dunn', 'Female', '08985 Arkansas Park', '9-(847)856-1', 'jdunn@realfire.name'),
(44, 44, 'Carolyn', 'Duncan', 'Female', '51 Karstens Pass', '4-(118)246-9', 'cduncan@flipopia.net'),
(45, 45, 'Edward', 'Porter', 'Female', '10 Commercial Crossing', '6-(649)612-8', 'eporter@eabox.mil'),
(46, 46, 'Martin', 'Roberts', 'Male', '139 Westerfield Hill', '9-(934)880-3', 'mroberts@vidoo.biz'),
(47, 47, 'Louise', 'Kelley', 'Female', '58451 East Parkway', '0-(836)541-1', 'lkelley@dabz.info'),
(48, 48, 'Fred', 'Franklin', 'Male', '5785 Ridge Oak Alley', '8-(369)492-1', 'ffranklin@trilith.biz'),
(49, 49, 'Mildred', 'Frazier', 'Female', '724 Susan Parkway', '3-(400)368-5', 'mfrazier@jabbertype.info'),
(50, 50, 'Ronald', 'Olson', 'Female', '92 Grasskamp Center', '9-(126)115-0', 'rolson@shufflester.edu'),
(51, 51, 'Donna', 'Garcia', 'Male', '2386 Kenwood Road', '2-(754)033-9', 'dgarcia@katz.gov'),
(52, 52, 'Gary', 'Harper', 'Female', '4 Darwin Pass', '7-(244)050-5', 'gharper@einti.biz'),
(53, 53, 'Matthew', 'Lopez', 'Male', '85399 Brown Way', '2-(736)822-5', 'mlopez@buzzshare.edu'),
(54, 54, 'James', 'Hill', 'Female', '79019 Linden Crossing', '3-(847)190-2', 'jhill@mydo.edu'),
(55, 55, 'Jose', 'Boyd', 'Female', '26 Norway Maple Circle', '6-(302)715-0', 'jboyd@fivespan.edu'),
(56, 56, 'Christine', 'Fuller', 'Male', '1 Sachs Junction', '3-(532)689-4', 'cfuller@roomm.name'),
(57, 57, 'Kelly', 'Romero', 'Female', '19525 Colorado Avenue', '6-(494)196-9', 'kromero@yata.net'),
(58, 58, 'Lois', 'Cunningham', 'Female', '80 Sugar Court', '2-(389)381-0', 'lcunningham@brainfire.net'),
(59, 59, 'Robin', 'Thompson', 'Female', '739 Pleasure Hill', '5-(249)274-9', 'rthompson@topdrive.gov'),
(60, 60, 'Lois', 'Jordan', 'Female', '292 Elka Way', '7-(366)978-5', 'ljordan@innojam.name'),
(61, 61, 'Janice', 'Bradley', 'Female', '8 Blue Bill Park Avenue', '5-(814)914-6', 'jbradley@jazzy.name'),
(62, 62, 'Martha', 'Oliver', 'Female', '4 Loomis Way', '2-(336)004-4', 'moliver@skinix.info'),
(63, 63, 'Anna', 'Hayes', 'Male', '53 Jenna Avenue', '8-(278)081-5', 'ahayes@gabtune.com'),
(64, 64, 'Ruth', 'Robertson', 'Female', '19940 Sugar Lane', '0-(438)765-0', 'rrobertson@avamm.biz'),
(65, 65, 'Helen', 'Webb', 'Male', '08 Hazelcrest Alley', '0-(970)521-4', 'hwebb@topdrive.com'),
(66, 66, 'Juan', 'Coleman', 'Female', '37187 1st Drive', '1-(900)127-0', 'jcoleman@yodoo.com'),
(67, 67, 'Joan', 'Little', 'Male', '87 Valley Edge Point', '2-(726)855-2', 'jlittle@brightdog.com'),
(68, 68, 'Anna', 'Johnson', 'Female', '886 Pine View Lane', '2-(105)844-3', 'ajohnson@blogtag.info'),
(69, 69, 'Kevin', 'Alexander', 'Female', '6 Anzinger Alley', '0-(509)035-8', 'kalexander@twitterwire.biz'),
(70, 70, 'Steve', 'Alexander', 'Female', '5 Park Meadow Terrace', '5-(518)150-5', 'salexander@skipfire.biz'),
(71, 71, 'Norma', 'Scott', 'Male', '40 Eagan Center', '5-(220)876-4', 'nscott@skinder.org'),
(72, 72, 'Ronald', 'Ross', 'Male', '068 Elmside Road', '2-(697)295-5', 'rross@photojam.net'),
(73, 73, 'Jeffrey', 'Hudson', 'Female', '6105 Lien Crossing', '2-(988)990-9', 'jhudson@agivu.com'),
(74, 74, 'Phyllis', 'Bishop', 'Female', '73037 Dexter Place', '0-(055)976-3', 'pbishop@dabvine.org'),
(75, 75, 'Anne', 'Reed', 'Female', '15011 Quincy Circle', '0-(586)586-6', 'areed@lajo.org'),
(76, 76, 'Christopher', 'Hansen', 'Female', '961 Center Road', '3-(758)822-6', 'chansen@mynte.name'),
(77, 77, 'Louis', 'Martinez', 'Male', '6 3rd Center', '8-(116)836-0', 'lmartinez@edgeify.name'),
(78, 78, 'Ronald', 'Walker', 'Male', '70 Ilene Place', '8-(128)904-9', 'rwalker@jaxnation.info'),
(79, 79, 'Amy', 'Spencer', 'Male', '580 Reinke Trail', '1-(063)164-2', 'aspencer@mynte.name'),
(80, 80, 'Paula', 'Morris', 'Male', '53 Schiller Road', '0-(497)358-6', 'pmorris@riffpath.com'),
(81, 81, 'Kimberly', 'Ramos', 'Female', '58296 Washington Center', '7-(649)245-5', 'kramos@demivee.net'),
(82, 82, 'Wanda', 'Allen', 'Female', '95532 Southridge Center', '8-(551)328-9', 'wallen@avamba.name'),
(83, 83, 'Todd', 'Sanders', 'Female', '715 Nancy Point', '3-(291)306-9', 'tsanders@gabcube.org'),
(84, 84, 'Beverly', 'Burns', 'Male', '4 Holmberg Park', '6-(787)221-0', 'bburns@voonder.gov'),
(85, 85, 'Larry', 'Collins', 'Male', '754 Grasskamp Hill', '1-(100)655-4', 'lcollins@skalith.net'),
(86, 86, 'Howard', 'Mendoza', 'Male', '3 Ruskin Way', '0-(884)004-3', 'hmendoza@blogtag.name'),
(87, 87, 'Gerald', 'White', 'Female', '95 Dovetail Trail', '9-(171)302-3', 'gwhite@skyvu.biz'),
(88, 88, 'Chris', 'Cunningham', 'Female', '83045 Golf Course Way', '4-(951)108-4', 'ccunningham@realmix.com'),
(89, 89, 'Lisa', 'Flores', 'Female', '7 Eastwood Way', '4-(417)257-8', 'lflores@ooba.org'),
(90, 90, 'Debra', 'Wells', 'Male', '8 Ruskin Pass', '3-(966)046-0', 'dwells@devpulse.edu'),
(91, 91, 'Raymond', 'Sanders', 'Male', '9027 Brentwood Street', '6-(298)645-8', 'rsanders@skyba.edu'),
(92, 92, 'Brian', 'Ellis', 'Male', '95 Chinook Avenue', '6-(402)447-0', 'bellis@buzzshare.gov'),
(93, 93, 'Sean', 'Ward', 'Male', '75 Ruskin Circle', '8-(834)089-7', 'sward@mynte.edu'),
(94, 94, 'Richard', 'Jordan', 'Male', '47311 Homewood Place', '6-(502)288-5', 'rjordan@feedfish.com'),
(95, 95, 'Tammy', 'Baker', 'Female', '56640 Orin Way', '4-(141)338-5', 'tbaker@buzzshare.edu'),
(96, 96, 'Harold', 'Cook', 'Male', '41393 Del Sol Court', '2-(020)202-2', 'hcook@jumpxs.info'),
(97, 97, 'Fred', 'Morgan', 'Female', '2 Morning Point', '7-(694)618-4', 'fmorgan@zoonoodle.com'),
(98, 98, 'Tammy', 'Martin', 'Female', '55 North Parkway', '3-(926)715-1', 'tmartin@mymm.net'),
(99, 99, 'John', 'Ray', 'Female', '81838 Tony Road', '4-(902)199-4', 'jray@roodel.gov'),
(100, 100, 'Adam', 'Spencer', 'Female', '620 Autumn Leaf Terrace', '8-(461)053-6', 'aspencer@edgetag.gov');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
CREATE TABLE IF NOT EXISTS `payment` (
  `payment_id` int(11) NOT NULL AUTO_INCREMENT,
  `invoice_id` int(11) NOT NULL,
  `amount` decimal(10,0) NOT NULL,
  `method` varchar(12) COLLATE utf8_unicode_ci NOT NULL,
  `date` date NOT NULL,
  `recipt_number` int(11) NOT NULL,
  PRIMARY KEY (`payment_id`),
  KEY `invoice_id` (`invoice_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=14 ;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`payment_id`, `invoice_id`, `amount`, `method`, `date`, `recipt_number`) VALUES
(1, 2, '100', 'CASH', '2014-06-23', 1111),
(2, 3, '300', 'CREDIT CARD', '2014-06-03', 1211),
(3, 5, '350', 'CASH', '2014-06-17', 1231213),
(4, 5, '50', 'CREDIT CARD', '2014-06-20', 1314124),
(10, 75, '200', 'Card', '2014-06-25', 0),
(11, 75, '200', 'Card', '2014-06-25', 0),
(12, 79, '5', 'Card', '2014-06-25', 0),
(13, 79, '5', 'Card', '2014-06-25', 0);

-- --------------------------------------------------------

--
-- Table structure for table `practitioner`
--

DROP TABLE IF EXISTS `practitioner`;
CREATE TABLE IF NOT EXISTS `practitioner` (
  `practitioner_id` int(11) NOT NULL AUTO_INCREMENT,
  `staff_id` int(11) NOT NULL,
  `type` varchar(24) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`practitioner_id`),
  KEY `staff_id` (`staff_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `practitioner`
--

INSERT INTO `practitioner` (`practitioner_id`, `staff_id`, `type`) VALUES
(1, 1, 'Radiologist'),
(2, 2, 'GP'),
(3, 3, 'GP');

-- --------------------------------------------------------

--
-- Table structure for table `roster`
--

DROP TABLE IF EXISTS `roster`;
CREATE TABLE IF NOT EXISTS `roster` (
  `roster_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `startDate` date NOT NULL,
  `file` mediumblob NOT NULL,
  PRIMARY KEY (`roster_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `sample`
--

DROP TABLE IF EXISTS `sample`;
CREATE TABLE IF NOT EXISTS `sample` (
  `sample_id` int(11) NOT NULL,
  `consultation_id` int(11) NOT NULL,
  `type` varchar(8) COLLATE utf8_unicode_ci NOT NULL,
  `results` text COLLATE utf8_unicode_ci NOT NULL,
  `reason` text COLLATE utf8_unicode_ci NOT NULL,
  `description` text COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`sample_id`),
  KEY `consultation_id` (`consultation_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `shift`
--

DROP TABLE IF EXISTS `shift`;
CREATE TABLE IF NOT EXISTS `shift` (
  `shift_id` int(11) NOT NULL AUTO_INCREMENT,
  `staff_id` int(11) NOT NULL,
  `start_time` datetime NOT NULL,
  `end_time` datetime DEFAULT NULL,
  PRIMARY KEY (`shift_id`),
  KEY `staff_id` (`staff_id`),
  KEY `staff_id_2` (`staff_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=6 ;

--
-- Dumping data for table `shift`
--

INSERT INTO `shift` (`shift_id`, `staff_id`, `start_time`, `end_time`) VALUES
(1, 2, '2014-06-25 15:32:40', '2014-06-25 15:32:41'),
(2, 2, '2014-06-25 15:32:48', '2014-06-25 15:32:50'),
(3, 1, '2014-06-25 15:50:05', '2014-06-25 16:36:08'),
(4, 2, '2014-06-25 16:15:47', '2014-06-25 16:41:22'),
(5, 1, '2014-06-25 16:36:12', '2014-06-25 16:37:29');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
CREATE TABLE IF NOT EXISTS `staff` (
  `staff_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `admin` tinyint(1) NOT NULL DEFAULT '0',
  `first_name` varchar(24) COLLATE utf8_unicode_ci NOT NULL,
  `last_name` varchar(24) COLLATE utf8_unicode_ci NOT NULL,
  `gender` varchar(6) COLLATE utf8_unicode_ci NOT NULL,
  `address` varchar(48) COLLATE utf8_unicode_ci DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `phone` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`staff_id`),
  KEY `user_id` (`user_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staff_id`, `user_id`, `admin`, `first_name`, `last_name`, `gender`, `address`, `dob`, `phone`) VALUES
(1, 15, 1, 'Peter', 'Rumsey', 'Male', 'Gosford', '2014-06-18', '0468889220'),
(2, 369250993, 0, 'Alter Ego', 'Rumsey', 'Male', 'Gosford', '2014-06-25', '040040404'),
(3, 369250995, 1, 'Connor', 'Dodd', 'Male', '125 ourimbah rd', '1995-01-19', '44440000');

-- --------------------------------------------------------

--
-- Table structure for table `token`
--

DROP TABLE IF EXISTS `token`;
CREATE TABLE IF NOT EXISTS `token` (
  `token_id` int(11) NOT NULL AUTO_INCREMENT,
  `staff_id` int(11) NOT NULL,
  `token` varchar(64) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`token_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=18281 ;

--
-- Dumping data for table `token`
--

INSERT INTO `token` (`token_id`, `staff_id`, `token`) VALUES
(18278, 2, 'HIJBH6EQFU7GPWYSWHI4JUQML2CVUAIPZVPSIY5FMUEV48RRZODQZVMW16ZN4S5F');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(48) COLLATE utf8_unicode_ci NOT NULL,
  `username` varchar(24) COLLATE utf8_unicode_ci NOT NULL,
  `password_hash` varchar(32) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `username` (`username`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=369250997 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `email`, `username`, `password_hash`) VALUES
(369250993, 'notadmin@holistic.com', 'notadmin', '5f4dcc3b5aa765d61d8327deb882cf99'),
(369250994, 'bobo', 'bob', '5f4dcc3b5aa765d61d8327deb882cf99'),
(369250995, 'connor.dodd19@gmail.com', 'connordodd', '5f4dcc3b5aa765d61d8327deb882cf99'),
(369250996, 'patient', 'mr', 'e2a1715ac00b5e872a2191fb13f69a69'),
(15, 'pete.rumsey@gmail.com', 'prumsey', '5f4dcc3b5aa765d61d8327deb882cf99');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

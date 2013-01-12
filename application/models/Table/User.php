<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of User
 *
 * @author marcin
 */
class Application_Model_Table_User extends Zend_Db_Table {
   
    protected $_name = 'Użytkownicy';
    protected $_schema = 'dbo';
    protected $_rowClass = 'Model_User';
}

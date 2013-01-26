INSERT INTO privillage(
            id_res, resource)
    VALUES (nextval('privillage_id_res_seq'::regclass), 'Root'),(nextval('privillage_id_res_seq'::regclass),'Root.add'),(nextval('privillage_id_res_seq'::regclass),'User'),(nextval('privillage_id_res_seq'::regclass),'User.join');

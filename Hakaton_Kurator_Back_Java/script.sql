create sequence kurator_teachers_user_id_seq
    as integer;

alter sequence kurator_teachers_user_id_seq owner to postgres;

create sequence kurator_teachers_slave_id_seq
    as integer;

alter sequence kurator_teachers_slave_id_seq owner to postgres;

create sequence group_id_seq
    as integer;

alter sequence group_id_seq owner to postgres;

create sequence group_userid_seq
    as integer;

alter sequence group_userid_seq owner to postgres;

create sequence group_slaveid_seq
    as integer;

alter sequence group_slaveid_seq owner to postgres;

create table users
(
    id    serial
        constraint users_pk
            primary key,
    role  text not null,
    token text
);

alter table users
    owner to postgres;

create table kurator_teachers
(
    id      serial,
    userid  integer default nextval('kurator.kurator_teachers_user_id_seq'::regclass)  not null
        constraint kurator_teachers_users_id_fk2
            references users,
    slaveid integer default nextval('kurator.kurator_teachers_slave_id_seq'::regclass) not null
        constraint kurator_teachers_users_id_fk
            references users,
    constraint kurator_teachers_pk
        primary key (userid, slaveid)
);

alter table kurator_teachers
    owner to postgres;

alter sequence kurator_teachers_user_id_seq owned by kurator_teachers.userid;

alter sequence kurator_teachers_slave_id_seq owned by kurator_teachers.slaveid;

create table contacts
(
    id      serial,
    userid  serial
        constraint contacts_pk
            primary key
        constraint contacts_users_id_fk
            references users,
    phone   text,
    tg      text,
    reserve text,
    email   text not null
        constraint contacts_pk2
            unique
);

alter table contacts
    owner to postgres;

create table ratings
(
    id        integer generated always as identity,
    userid    integer not null
        constraint ratings_pk
            primary key
        constraint ratings_users_id_fk
            references users,
    education real    not null,
    social    real    not null,
    documents real    not null,
    factor    real    not null
);

alter table ratings
    owner to postgres;

create table events
(
    id          integer not null
        constraint events_pk
            primary key,
    title       text    not null,
    description text,
    link        text,
    views       integer not null,
    nextdate    bigint  not null,
    lastdate    bigint,
    tags        text    not null,
    rating      real    not null,
    dynamic     real    not null
);

alter table events
    owner to postgres;

create table event_comments
(
    id      serial
        constraint event_comments_pk
            primary key,
    eventid serial
        constraint event_comments_events_id_fk
            references events,
    userid  serial
        constraint event_comments_users_id_fk
            references users,
    comment text   not null,
    date    bigint not null
);

alter table event_comments
    owner to postgres;

create table ratingchange
(
    id     serial,
    userid serial,
    date   bigint not null,
    factor real   not null,
    constraint ratingchange_pk
        primary key (userid, date)
);

alter table ratingchange
    owner to postgres;

create table groups
(
    id        integer default nextval('kurator.group_id_seq'::regclass)      not null,
    userid    integer default nextval('kurator.group_userid_seq'::regclass)  not null
        constraint group_users_id_fk
            references users,
    slaveid   integer default nextval('kurator.group_slaveid_seq'::regclass) not null
        constraint groups_users_id_fk
            references users,
    groupname text                                                           not null
        constraint groups_pk
            primary key
);

alter table groups
    owner to postgres;

alter sequence group_id_seq owned by groups.id;

alter sequence group_userid_seq owned by groups.userid;

alter sequence group_slaveid_seq owned by groups.slaveid;

create table documents
(
    id          serial
        constraint documents_pk
            primary key,
    "group"     text   not null
        constraint documents_group_group_fk
            references groups,
    title       text   not null,
    description text,
    lastupdate  bigint not null,
    status      text   not null
);

alter table documents
    owner to postgres;

create table forum
(
    id    serial
        constraint forum_pk
            primary key,
    title text not null,
    theme text not null
);

alter table forum
    owner to postgres;

create table forum_section
(
    id          serial
        constraint forum_section_pk
            primary key,
    forumid     serial
        constraint forum_section_forum_id_fk
            references forum,
    title       text not null,
    description text not null
);

alter table forum_section
    owner to postgres;

create table forum_section_theme
(
    forumsectionid serial
        constraint forum_section_theme_forum_section_id_fk
            references forum_section,
    title          text   not null,
    description    text   not null,
    lastupdate     bigint not null,
    id             serial
        constraint forum_section_theme_pk
            primary key
);

alter table forum_section_theme
    owner to postgres;

create table materials
(
    id      serial
        constraint materials_pk
            primary key,
    ratings real,
    factor  real,
    links   text,
    views   integer not null,
    date    bigint  not null,
    title   text    not null
);

alter table materials
    owner to postgres;

create table material_comments
(
    id         integer generated always as identity,
    materialid bigint
        constraint material_comments_materials_id_fk
            references materials,
    userid     bigint
        constraint material_comments_users_id_fk
            references users,
    comment    text,
    date       bigint
);

alter table material_comments
    owner to postgres;



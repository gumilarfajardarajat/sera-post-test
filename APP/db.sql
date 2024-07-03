CREATE DATABASE SeraPostTest;
USE SeraPostTest;

CREATE TABLE PersonalData (
    PersonalID VARCHAR(50),
    FullName VARCHAR(100),
    ContractType VARCHAR(50)
);

CREATE TABLE PersonalIdentity (
    PersonalID VARCHAR(50),
    IdentityType VARCHAR(50),
    ExpiredDate DATE
);

-- Inserting data into PersonalData table
INSERT INTO PersonalData (PersonalID, FullName, ContractType)
VALUES
    ('11000', 'Driver01', 'PKWT'),
    ('11001', 'Driver02', 'PKWT'),
    ('11002', 'Driver03', 'MITRA'),
    ('11003', 'Driver04', 'MITRA');

-- Inserting data into PersonalIdentity table
INSERT INTO PersonalIdentity (PersonalID, IdentityType, ExpiredDate)
VALUES
    ('11000', 'KTP', '9999-12-31'),
    ('11000', 'SIM A', '2024-06-30'),
    ('11000', 'SIM B', '2024-12-31'),
    ('11001', 'KTP', '9999-12-31'),
    ('11001', 'SIM A', '2024-01-01'),
    ('11001', 'SIM B II UMUM', '2025-01-01'),
    ('11002', 'KTP', '9999-12-31'),
    ('11003', 'SIM A', '2022-10-10'),
    ('11003', 'SIM C', '2024-07-31');



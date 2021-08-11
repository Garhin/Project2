CREATE TABLE "infant" (
    "frequency" VARARCH(5)  NOT NULL,
    "indicator" VARARCH(5)   NOT NULL,
    "location" VARARCH(5)   NOT NULL,
    "time" INT  NOT NULL,
    "value" INT   NOT NULL,
    "subject" VARCHAR(1)   NOT NULL,
)

CREATE TABLE "LIFE" (
    "frequency" VARARCH(5)  NOT NULL,
    "indicator" VARARCH(5)   NOT NULL,
    "location" VARARCH(5)   NOT NULL,
    "time" INT  NOT NULL,
    "value" INT   NOT NULL,
    "subject" VARCHAR(1)   NOT NULL,
)
    
SELECT
*
FROM
infant

SELECT
*
FROM
life

SELECT
*
FROM
infant
INNER JOIN life ON infant.location=life.location
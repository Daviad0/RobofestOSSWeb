CREATE TABLE "GAMES" (
    "GameID" integer NOT NULL,
    "Name" text NULL,
    "Desc" text NULL,
    CONSTRAINT "PK_GAMES" PRIMARY KEY ("GameID")
);

CREATE TABLE "Competitions" (
    "CompID" integer NOT NULL,
    "GameID" integer NOT NULL,
    "Location" text NULL,
    "ExtraData" text NULL,
    "Date" timestamp without time zone NOT NULL,
    "RunningFields" integer NOT NULL,
    "ScheduleNumber" integer NOT NULL,
    field1preferred integer NOT NULL,
    field2preferred integer NOT NULL,
    field3preferred integer NOT NULL,
    field4preferred integer NOT NULL,
    field5preferred integer NOT NULL,
    field6preferred integer NOT NULL,
    CONSTRAINT "PK_Competitions" PRIMARY KEY ("CompID"),
    CONSTRAINT "FK_Competitions_GAMES_GameID" FOREIGN KEY ("GameID") REFERENCES "GAMES" ("GameID") ON DELETE CASCADE
);

CREATE TABLE "ScoreMethods" (
    "MethodID" integer NOT NULL,
    "GameID" integer NOT NULL,
    "Name" text NULL,
    CONSTRAINT "PK_ScoreMethods" PRIMARY KEY ("MethodID"),
    CONSTRAINT "FK_ScoreMethods_GAMES_GameID" FOREIGN KEY ("GameID") REFERENCES "GAMES" ("GameID") ON DELETE CASCADE
);

CREATE TABLE "Fields" (
    "FieldID" integer NOT NULL,
    "FieldNumber" integer NOT NULL,
    "CompID" integer NOT NULL,
    "CurrentTeamID" integer NOT NULL,
    "Using" boolean NOT NULL,
    "Junior" boolean NOT NULL,
    "CurrentTeamNumber" text NULL,
    CONSTRAINT "PK_Fields" PRIMARY KEY ("FieldID"),
    CONSTRAINT "FK_Fields_Competitions_CompID" FOREIGN KEY ("CompID") REFERENCES "Competitions" ("CompID") ON DELETE CASCADE
);

CREATE TABLE "StudentTeams" (
    "TeamID" integer NOT NULL,
    "CompID" integer NOT NULL,
    "TeamName" text NOT NULL,
    "TeamNumberBranch" integer NOT NULL,
    "TeamNumberSpecific" integer NOT NULL,
    "Location" text NULL,
    "Coach" text NOT NULL,
    "FieldR1" integer NOT NULL,
    "FieldR2" integer NOT NULL,
    CONSTRAINT "PK_StudentTeams" PRIMARY KEY ("TeamID"),
    CONSTRAINT "FK_StudentTeams_Competitions_CompID" FOREIGN KEY ("CompID") REFERENCES "Competitions" ("CompID") ON DELETE CASCADE
);

CREATE TABLE "ScoreAmounts" (
    "AmountID" integer NOT NULL,
    "MethodID" integer NOT NULL,
    "AmountName" text NULL,
    "Amount" integer NOT NULL,
    CONSTRAINT "PK_ScoreAmounts" PRIMARY KEY ("AmountID"),
    CONSTRAINT "FK_ScoreAmounts_ScoreMethods_MethodID" FOREIGN KEY ("MethodID") REFERENCES "ScoreMethods" ("MethodID") ON DELETE CASCADE
);

CREATE TABLE "RoundEntries" (
    "EntryID" integer NOT NULL,
    "TeamID" integer NOT NULL,
    "Round" integer NOT NULL,
    "Score" integer NOT NULL,
    "Time" integer NOT NULL,
    "Data" text NULL,
    "Rerun" boolean NOT NULL,
    "Usable" boolean NOT NULL,
    "JudgeConfirmNotes" text NULL,
    "StudentInitials" text NULL,
    "TimeStamp" text NULL,
    "Field" integer NOT NULL,
    CONSTRAINT "PK_RoundEntries" PRIMARY KEY ("EntryID"),
    CONSTRAINT "FK_RoundEntries_StudentTeams_TeamID" FOREIGN KEY ("TeamID") REFERENCES "StudentTeams" ("TeamID") ON DELETE CASCADE
);

CREATE TABLE "TeamMatches" (
    "MatchID" integer NOT NULL,
    "TeamID" integer NOT NULL,
    "Order" integer NOT NULL,
    "Rerun" boolean NOT NULL,
    "Test" boolean NOT NULL,
    "Completed" boolean NOT NULL,
    CONSTRAINT "PK_TeamMatches" PRIMARY KEY ("MatchID"),
    CONSTRAINT "FK_TeamMatches_StudentTeams_TeamID" FOREIGN KEY ("TeamID") REFERENCES "StudentTeams" ("TeamID") ON DELETE CASCADE
);

CREATE TABLE "PresetAccounts" (
    "PresetAccoutID" text NOT NULL,
    "Email" text NULL,
    "Username" text NULL,
    "PublicPasskey" text NULL,
    "CompID" integer NOT NULL,
    CONSTRAINT "PK_PresetAccounts" PRIMARY KEY ("PresetAccoutID"),
    CONSTRAINT "FK_PresetAccounts_Competitions_CompID" FOREIGN KEY ("CompID") REFERENCES "Competitions" ("CompID") ON DELETE CASCADE
);
CREATE INDEX "IX_Competitions_GameID" ON "Competitions" ("GameID");

CREATE INDEX "IX_Fields_CompID" ON "Fields" ("CompID");

CREATE INDEX "IX_RoundEntries_TeamID" ON "RoundEntries" ("TeamID");

CREATE INDEX "IX_ScoreAmounts_MethodID" ON "ScoreAmounts" ("MethodID");

CREATE INDEX "IX_ScoreMethods_GameID" ON "ScoreMethods" ("GameID");

CREATE INDEX "IX_StudentTeams_CompID" ON "StudentTeams" ("CompID");
CREATE INDEX "IX_TeamMatches_TeamID" ON "TeamMatches" ("TeamID");

ALTER TABLE "TeamMatches" DROP CONSTRAINT "FK_TeamMatches_StudentTeams_TeamID";

ALTER TABLE "TeamMatches" RENAME COLUMN "TeamID" TO "CompID";

ALTER INDEX "IX_TeamMatches_TeamID" RENAME TO "IX_TeamMatches_CompID";

ALTER TABLE "TeamMatches" ADD "TeamNumber" text NULL;

ALTER TABLE "TeamMatches" ADD CONSTRAINT "FK_TeamMatches_Competitions_CompID" FOREIGN KEY ("CompID") REFERENCES "Competitions" ("CompID") ON DELETE CASCADE;

ALTER TABLE "TeamMatches" ADD "RoundNum" integer NOT NULL DEFAULT 0;

ALTER TABLE "TeamMatches" DROP CONSTRAINT "FK_TeamMatches_Competitions_CompID";

DROP INDEX "IX_TeamMatches_CompID";


ALTER TABLE "Competitions" ALTER COLUMN field6preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field6preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field6preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field5preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field5preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field5preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field4preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field4preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field4preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field3preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field3preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field3preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field2preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field2preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field2preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field1preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field1preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field1preferred DROP DEFAULT;


ALTER TABLE "Competitions" ADD validmatch1 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch2 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch3 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch4 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch5 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch6 boolean NOT NULL DEFAULT FALSE;


ALTER TABLE "TeamMatches" ALTER COLUMN "MatchID" TYPE integer;
ALTER TABLE "TeamMatches" ALTER COLUMN "MatchID" SET NOT NULL;
ALTER TABLE "TeamMatches" ALTER COLUMN "MatchID" DROP DEFAULT;

ALTER TABLE "StudentTeams" ALTER COLUMN "TeamID" TYPE integer;
ALTER TABLE "StudentTeams" ALTER COLUMN "TeamID" SET NOT NULL;
ALTER TABLE "StudentTeams" ALTER COLUMN "TeamID" DROP DEFAULT;

ALTER TABLE "ScoreMethods" ALTER COLUMN "MethodID" TYPE integer;
ALTER TABLE "ScoreMethods" ALTER COLUMN "MethodID" SET NOT NULL;
ALTER TABLE "ScoreMethods" ALTER COLUMN "MethodID" DROP DEFAULT;

ALTER TABLE "ScoreAmounts" ALTER COLUMN "AmountID" TYPE integer;
ALTER TABLE "ScoreAmounts" ALTER COLUMN "AmountID" SET NOT NULL;
ALTER TABLE "ScoreAmounts" ALTER COLUMN "AmountID" DROP DEFAULT;

ALTER TABLE "RoundEntries" ALTER COLUMN "EntryID" TYPE integer;
ALTER TABLE "RoundEntries" ALTER COLUMN "EntryID" SET NOT NULL;
ALTER TABLE "RoundEntries" ALTER COLUMN "EntryID" DROP DEFAULT;

ALTER TABLE "GAMES" ALTER COLUMN "GameID" TYPE integer;
ALTER TABLE "GAMES" ALTER COLUMN "GameID" SET NOT NULL;
ALTER TABLE "GAMES" ALTER COLUMN "GameID" DROP DEFAULT;

ALTER TABLE "Fields" ALTER COLUMN "FieldID" TYPE integer;
ALTER TABLE "Fields" ALTER COLUMN "FieldID" SET NOT NULL;
ALTER TABLE "Fields" ALTER COLUMN "FieldID" DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN "CompID" TYPE integer;
ALTER TABLE "Competitions" ALTER COLUMN "CompID" SET NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN "CompID" DROP DEFAULT;

ALTER TABLE "Competitions" ADD setup boolean NOT NULL DEFAULT FALSE;

CREATE INDEX "IX_PresetAccounts_CompID" ON "PresetAccounts" ("CompID");

INSERT INTO "GAMES" ("GameID", "Name", "Desc")
VALUES (1, 'Robobowl', 'Perfect score of not 300');

INSERT INTO "Competitions" ("CompID", "GameID", "Location", "ExtraData", "Date", "RunningFields", "ScheduleNumber" ,"field1preferred", "field2preferred", "field3preferred", "field4preferred", "field5preferred", "field6preferred", "validmatch1", "validmatch2", "validmatch3", "validmatch4", "validmatch5", "validmatch6", "setup")
VALUES (1, 1, 'Robofest World Championship', 'Yeet', '1/1/2020 12:00:00 AM', 6, 1, '1001-1', '1001-2', '1001-3', '1001-4', '1001-5', '1001-6', FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE);

INSERT INTO "StudentTeams" ("TeamID", "Coach", "CompID", "FieldR1", "FieldR2", "Location", "TeamName", "TeamNumberBranch", "TeamNumberSpecific")
VALUES (-1, 'Robofest', 1, 0, 0, 'Robofest', 'Test Team 1', 999, 1);

INSERT INTO "StudentTeams" ("TeamID", "Coach", "CompID", "FieldR1", "FieldR2", "Location", "TeamName", "TeamNumberBranch", "TeamNumberSpecific")
VALUES (-2, 'Robofest', 1, 0, 0, 'Robofest', 'Test Team 2', 999, 2);

ALTER TABLE "Competitions" ADD RunningState integer NULL DEFAULT 0;




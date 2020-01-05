const mongoose = require("mongoose");
const repositorySchema = new mongoose.Schema({
    username: {
        id: {
            type: Number
        },
        node_id: {
            type: String
        },
        name: {
            type: String
        },
        full_name: {
            type: String
        },
        private: {
            type: Boolean
        },
        owner: {
            type: Object
        },
        html_url: {
            type: String
        },
        description: {
            type: String
        },
        fork: {
            type: Boolean
        },
        url: {
            type: String
        },
        forks_url: {
            type: String
        },
        keys_url: {
            type: String
        },
        collaborators_url: {
            type: String
        },
        teams_url: {
            type: String
        },
        hooks_url: {
            type: String
        },
        issue_events_url: {
            type: String
        },
        events_url: {
            type: String
        },
        assignees_url: {
            type: String
        },
        branches_url: {
            type: String
        },
        tags_url: {
            type: String
        },
        blobs_url: {
            type: String
        },
        git_tags_url: {
            type: String
        },
        git_refs_url: {
            type: String
        },
        trees_url: {
            type: String
        },
        statuses_url: {
            type: String
        },
        languages_url: {
            type: String
        },
        stargazers_url: {
            type: String
        },
        contributors_url: {
            type: String
        },
        subscribers_url: {
            type: String
        },
        subscription_url: {
            type: String
        },
        commits_url: {
            type: String
        },
        git_commits_url: {
            type: String
        },
        comments_url: {
            type: String
        },
        issue_comment_url: {
            type: String
        },
        contents_url: {
            type: String
        },
        compare_url: {
            type: String
        },
        merges_url: {
            type: String
        },
        archive_url: {
            type: String
        },
        downloads_url: {
            type: String
        },
        issues_url: {
            type: String
        },
        pulls_url: {
            type: String
        },
        milestones_url: {
            type: String
        },
        notifications_url: {
            type: String
        },
        labels_url: {
            type: String
        },
        releases_url: {
            type: String
        },
        deployments_url: {
            type: String
        },
        created_at: {
            type: String
        },
        updated_at: {
            type: String
        },
        pushed_at: {
            type: String
        },
        git_url: {
            type: String
        },
        ssh_url: {
            type: String
        },
        clone_url: {
            type: String
        },
        svn_url: {
            type: String
        },
        homepage: {
            type: String
        },
        size: {
            type: Number
        },
        stargazers_count: {
            type: Number
        },
        watchers_count: {
            type: Number
        },
        language: {
            type: String
        },
        has_issues: {
            type: Boolean
        },
        has_projects: {
            type: Boolean
        },
        has_downloads: {
            type: Boolean
        },
        has_wiki: {
            type: Boolean
        },
        has_pages: {
            type: Boolean
        },
        forks_count: {
            type: Number
        },
        mirror_url: {
            type: String
        },
        archived: {
            type: Boolean
        },
        disabled: {
            type: Boolean
        },
        open_issues_count: {
            type: Number
        },
        license: {
            type: Object
        },
        forks: {
            type: Number
        },
        open_issues: {
            type: Number
        },
        watchers: {
            type: Number
        },
        default_branch: {
            type: String
        }
    }
});
const Repository = mongoose.model("Repository", repositorySchema, "repositories");
module.exports = Repository;
